using System.Collections.Generic;

namespace Definux.Emeraude.Client.Models
{
    /// <summary>
    /// Implementation of meta tags for HTML for search engine optimization.
    /// </summary>
    public class MetaTagsModel
    {
        /// <summary>
        /// Title suffix for all pages. Example ' | Application' for 'Home | Application'.
        /// </summary>
        public string TitleSuffix { get; set; }

        /// <summary>
        /// Canonical link of the page.
        /// </summary>
        public string Canonical { get; set; }

        /// <summary>
        /// HTML charset. Default value is "utf-8".
        /// </summary>
        public string Charset { get; set; } = "utf-8";

        /// <summary>
        /// Viewport of the HTML. Default value is "width=device-width, initial-scale=1.0".
        /// </summary>
        public MetaTag Viewport { get; } = new MetaTag("viewport", "width=device-width, initial-scale=1.0");

        /// <summary>
        /// Robots tag. Default value is "index, follow".
        /// </summary>
        public MetaTag Robots { get; } = new MetaTag("robots", "index, follow");

        /// <summary>
        /// Title of the page.
        /// </summary>
        public MetaTag Title { get; } = new MetaTag("title");

        /// <summary>
        /// Description of the page.
        /// </summary>
        public MetaTag Description { get; } = new MetaTag("description");

        /// <summary>
        /// Keywords of the page.
        /// </summary>
        public MetaTag Keywords { get; } = new MetaTag("keywords");

        /// <summary>
        /// Author of the page.
        /// </summary>
        public MetaTag Author { get; } = new MetaTag("author");

        /// <summary>
        /// Facebook Open Graph type meta tag.
        /// </summary>
        public MetaTag OpenGraphType { get; } = new MetaTag("og:type") { KeyName = "property" };

        /// <summary>
        /// Facebook Open Graph title meta tag.
        /// </summary>
        public MetaTag OpenGraphTitle { get; } = new MetaTag("og:title") { KeyName = "property" };

        /// <summary>
        /// Facebook Open Graph description meta tag.
        /// </summary>
        public MetaTag OpenGraphDescription { get; } = new MetaTag("og:description") { KeyName = "property" };

        /// <summary>
        /// Facebook Open Graph image meta tag.
        /// </summary>
        public MetaTag OpenGraphImage { get; } = new MetaTag("og:image") { KeyName = "property" };

        /// <summary>
        /// Facebook Open Graph URL meta tag.
        /// </summary>
        public MetaTag OpenGraphUrl { get; } = new MetaTag("og:url") { KeyName = "property" };

        /// <summary>
        /// Facebook Open Graph site name meta tag.
        /// </summary>
        public MetaTag OpenGraphSiteName { get; } = new MetaTag("og:site_name") { KeyName = "property" };

        /// <summary>
        /// Facebook application id meta tag.
        /// </summary>
        public MetaTag FacebookAppId { get; } = new MetaTag("fb:app_id") { KeyName = "property" };

        /// <summary>
        /// Twitter card meta tag.
        /// </summary>
        public MetaTag TwitterCard { get; } = new MetaTag("twitter:card");

        /// <summary>
        /// Twitter title meta tag.
        /// </summary>
        public MetaTag TwitterTitle { get; } = new MetaTag("twitter:title");

        /// <summary>
        /// Twitter description meta tag.
        /// </summary>
        public MetaTag TwitterDescription { get; } = new MetaTag("twitter:description");

        /// <summary>
        /// Twitter image meta tag.
        /// </summary>
        public MetaTag TwitterImage { get; } = new MetaTag("twitter:image");

        /// <summary>
        /// Twitter site meta tag.
        /// </summary>
        public MetaTag TwitterSite { get; } = new MetaTag("twitter:site");

        /// <summary>
        /// Twitter creator meta tag.
        /// </summary>
        public MetaTag TwitterCreator { get; } = new MetaTag("twitter:creator");

        /// <summary>
        /// Set title of the page.
        /// </summary>
        /// <param name="title"></param>
        public void SetTitle(string title)
        {
            if (title == null)
            {
                title = string.Empty;
            }

            string titleSuffix = this.TitleSuffix ?? string.Empty;
            titleSuffix = title.EndsWith(titleSuffix, System.StringComparison.OrdinalIgnoreCase) ? string.Empty : titleSuffix;
            this.Title.Value = title + titleSuffix;
            this.OpenGraphTitle.Value = title + titleSuffix;
            this.TwitterTitle.Value = title + titleSuffix;
        }

        /// <summary>
        /// Set description of the page.
        /// </summary>
        /// <param name="description"></param>
        public void SetDescription(string description)
        {
            this.Description.Value = description;
            this.OpenGraphDescription.Value = description;
            this.TwitterDescription.Value = description;
        }

        /// <summary>
        /// Set image of the page.
        /// </summary>
        /// <param name="imageUrl"></param>
        public void SetImage(string imageUrl)
        {
            this.OpenGraphImage.Value = imageUrl;
            this.TwitterImage.Value = imageUrl;
        }

        /// <summary>
        /// Set meta tag and its value.
        /// </summary>
        /// <param name="metaTag"></param>
        /// <param name="value"></param>
        public void SetMetaTag(MainMetaTags metaTag, string value)
        {
            switch (metaTag)
            {
                case MainMetaTags.Title:
                    this.SetTitle(value);
                    break;
                case MainMetaTags.Description:
                    this.SetDescription(value);
                    break;
                case MainMetaTags.Keywords:
                    this.Keywords.Value = value;
                    break;
                case MainMetaTags.Image:
                    this.SetImage(value);
                    break;
                case MainMetaTags.Author:
                    this.Author.Value = value;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Gets a list of all default meta tags.
        /// </summary>
        /// <returns></returns>
        public List<MetaTag> GetStartMetaTags()
        {
            var result = new List<MetaTag>();

            if (this.Viewport.HasValue)
            {
                result.Add(this.Viewport);
            }

            if (this.Robots.HasValue)
            {
                result.Add(this.Robots);
            }

            return result;
        }

        /// <summary>
        /// Gets list of all filled meta tags.
        /// </summary>
        /// <returns></returns>
        public List<MetaTag> GetFilledMetaTags()
        {
            var result = new List<MetaTag>();
            this.AddMetaTagIfHasValue(this.Title, result);
            this.AddMetaTagIfHasValue(this.Description, result);
            this.AddMetaTagIfHasValue(this.Keywords, result);
            this.AddMetaTagIfHasValue(this.Author, result);
            this.AddMetaTagIfHasValue(this.OpenGraphType, result);
            this.AddMetaTagIfHasValue(this.OpenGraphTitle, result);
            this.AddMetaTagIfHasValue(this.OpenGraphDescription, result);
            this.AddMetaTagIfHasValue(this.OpenGraphImage, result);
            this.AddMetaTagIfHasValue(this.OpenGraphUrl, result);
            this.AddMetaTagIfHasValue(this.OpenGraphSiteName, result);
            this.AddMetaTagIfHasValue(this.FacebookAppId, result);
            this.AddMetaTagIfHasValue(this.TwitterCard, result);
            this.AddMetaTagIfHasValue(this.TwitterTitle, result);
            this.AddMetaTagIfHasValue(this.TwitterDescription, result);
            this.AddMetaTagIfHasValue(this.TwitterImage, result);
            this.AddMetaTagIfHasValue(this.TwitterSite, result);
            this.AddMetaTagIfHasValue(this.TwitterCreator, result);

            return result;
        }

        /// <summary>
        /// Apply static meta tags to the current meta tag model.
        /// </summary>
        /// <param name="model"></param>
        public void ApplyStaticTags(MetaTagsModel model)
        {
            this.TitleSuffix = model.TitleSuffix;
            this.Charset = model.Charset;

            this.Viewport.Value = model.Viewport.Value;
            this.Robots.Value = model.Robots.Value;
            this.OpenGraphSiteName.Value = model.OpenGraphSiteName.Value;
            this.OpenGraphType.Value = model.OpenGraphType.Value;
            this.FacebookAppId.Value = model.FacebookAppId.Value;
            this.TwitterCard.Value = model.TwitterCard.Value;
            this.TwitterCreator.Value = model.TwitterCreator.Value;
            this.TwitterSite.Value = model.TwitterSite.Value;

            this.SetTitle(this.Title.Value);
            this.SetDescription(this.Description.Value);
            this.SetImage(this.OpenGraphImage.Value);
        }

        private void AddMetaTagIfHasValue(MetaTag metaTagForAdding, List<MetaTag> metaTags)
        {
            if (metaTagForAdding.HasValue)
            {
                metaTags.Add(metaTagForAdding);
            }
        }
    }
}
