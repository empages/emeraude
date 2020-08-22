using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Hosting;
using System;
using System.Threading;
using System.Threading.Tasks;


namespace Definux.Emeraude.Client.EmPages.Renderer
{
    [HtmlTargetElement(Attributes = EmeraudeAppAttributeName)]
    public class ViewRendererTagHelper : TagHelper
    {
#pragma warning disable 612, 618
        private const string EmeraudeAppAttributeName = "asp-emeraude-app";
        private const string ServerBundleAttributeName = "asp-server-bundle";
        private const string InitialStateViewModelAttributeName = "asp-initial-state";
        private const string TimeoutAttributeName = "asp-timeout";

        private readonly string applicationBasePath;
        private readonly CancellationToken applicationStoppingToken;
        private readonly INodeServices nodeServices;

        public ViewRendererTagHelper(IServiceProvider serviceProvider)
        {
            var hostEnvironment = (IHostEnvironment)serviceProvider.GetService(typeof(IHostEnvironment));
            this.nodeServices = (INodeServices)serviceProvider.GetService(typeof(INodeServices));
            this.applicationBasePath = hostEnvironment.ContentRootPath;

            var applicationLifetime = (IHostApplicationLifetime)serviceProvider.GetService(typeof(IHostApplicationLifetime));
            this.applicationStoppingToken = applicationLifetime.ApplicationStopping;
        }

        /// <summary>
        /// Flag that indicates Emeraude app initialization
        /// </summary>
        [HtmlAttributeName(EmeraudeAppAttributeName)]
        public bool ActivateEmeraude { get; set; }

        /// <summary>
        /// Specifies the path to the built application server bundle.
        /// </summary>
        [HtmlAttributeName(ServerBundleAttributeName)]
        public string ServerBundle { get; set; }

        /// <summary>
        /// An JSON-serializable parameter to be supplied to the current page as a store state.
        /// </summary>
        [HtmlAttributeName(InitialStateViewModelAttributeName)]
        public object InitialStateViewModel { get; set; }

        /// <summary>
        /// The maximum duration to wait for prerendering to complete.
        /// </summary>
        [HtmlAttributeName(TimeoutAttributeName)]
        public int TimeoutMillisecondsParameter { get; set; }

        /// <summary>
        /// The <see cref="ViewContext"/>.
        /// </summary>
        [HtmlAttributeNotBound]
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            if (ActivateEmeraude)
            {
                output.Attributes.Add(new TagHelperAttribute("id", "emeraude-app"));

                var result = await ViewRenderer.RenderToString(
                        this.applicationBasePath,
                        this.nodeServices,
                        this.applicationStoppingToken,
                        ServerBundle,
                        ViewContext.HttpContext,
                        InitialStateViewModel,
                        TimeoutMillisecondsParameter);

                if (!string.IsNullOrEmpty(result.RedirectUrl))
                {
                    // It's a redirection
                    var permanentRedirect = result.StatusCode.GetValueOrDefault() == 301;
                    ViewContext.HttpContext.Response.Redirect(result.RedirectUrl, permanentRedirect);
                    return;
                }

                if (result.StatusCode.HasValue)
                {
                    ViewContext.HttpContext.Response.StatusCode = result.StatusCode.Value;
                }

                // It's some HTML to inject
                output.Content.SetHtmlContent(result.Html);

                // Also attach any specified globals to the 'window' object. This is useful for transferring
                // general state between server and client.
                var globalsScript = result.CreateGlobalsAssignmentScript();
                if (!string.IsNullOrEmpty(globalsScript))
                {
                    output.PostElement.SetHtmlContent($"<script>{globalsScript}</script>");
                }
            }
            else
            {
                await base.ProcessAsync(context, output);
            }
        }
#pragma warning restore 612, 618
    }
}