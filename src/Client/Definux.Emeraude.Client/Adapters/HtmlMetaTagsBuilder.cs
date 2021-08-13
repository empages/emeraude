using System.Text;
using Definux.Emeraude.Client.Extensions;
using Definux.Emeraude.Client.UI.Adapters;
using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Definux.Emeraude.Client.Adapters
{
    /// <inheritdoc cref="IHtmlMetaTagsBuilder"/>
    public class HtmlMetaTagsBuilder : IHtmlMetaTagsBuilder
    {
        private readonly EmClientOptions clientOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="HtmlMetaTagsBuilder"/> class.
        /// </summary>
        /// <param name="optionsProvider"></param>
        public HtmlMetaTagsBuilder(IEmOptionsProvider optionsProvider)
        {
            this.clientOptions = optionsProvider.GetClientOptions();
        }

        /// <inheritdoc />
        public HtmlString GetCurrentPageMetaTags(ViewContext viewContext)
        {
            string htmlString = string.Empty;
            var metaTagsModel = viewContext.ViewData.GetMetaTagsModelOrDefault();
            if (metaTagsModel != null)
            {
                metaTagsModel.ApplyStaticTags(this.clientOptions.DefaultMetaTags);
                StringBuilder tagsBuilder = new StringBuilder();
                tagsBuilder.AppendLine($"<meta charset=\"{metaTagsModel.Charset}\" />");

                var startMetaTags = metaTagsModel.GetStartMetaTags();
                foreach (var startMetaTag in startMetaTags)
                {
                    tagsBuilder.AppendLine($"<meta {startMetaTag.KeyName}=\"{startMetaTag.Key}\" {startMetaTag.ValueName}=\"{startMetaTag.Value}\" />");
                }

                tagsBuilder.AppendLine($"<title>{metaTagsModel.Title.Value}</title>");
                tagsBuilder.AppendLine($"<link rel=\"canonical\" href=\"{metaTagsModel.Canonical}\"/>");

                var filledMetaTags = metaTagsModel.GetFilledMetaTags();
                foreach (var filledMetaTag in filledMetaTags)
                {
                    tagsBuilder.AppendLine($"<meta {filledMetaTag.KeyName}=\"{filledMetaTag.Key}\" {filledMetaTag.ValueName}=\"{filledMetaTag.Value}\" />");
                }

                htmlString = tagsBuilder.ToString();
            }

            return new HtmlString(htmlString);
        }
    }
}