using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Logging;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.NodeServices;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.Extensions.Hosting;

namespace Definux.Emeraude.Client.EmPages.Renderer
{
    /// <summary>
    /// EmPage Vue server-side rendering tag helper which prerender the Vue application by the server bundle and initial state model.
    /// </summary>
    [HtmlTargetElement(Attributes = EmeraudeAppAttributeName)]
    public class EmPageRendererTagHelper : TagHelper
    {
#pragma warning disable 612, 618
        private const string EmeraudeAppAttributeName = "asp-emeraude-app";
        private const string ServerBundleAttributeName = "asp-server-bundle";
        private const string InitialStateViewModelAttributeName = "asp-initial-state";
        private const string TimeoutAttributeName = "asp-timeout";

        private readonly string applicationBasePath;
        private readonly CancellationToken applicationStoppingToken;
        private readonly INodeServices nodeServices;
        private readonly ILogger logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageRendererTagHelper"/> class.
        /// </summary>
        /// <param name="serviceProvider"></param>
        /// <param name="logger"></param>
        public EmPageRendererTagHelper(IServiceProvider serviceProvider, ILogger logger)
        {
            var hostEnvironment = (IHostEnvironment)serviceProvider.GetService(typeof(IHostEnvironment));
            this.nodeServices = (INodeServices)serviceProvider.GetService(typeof(INodeServices));
            this.logger = logger;
            this.applicationBasePath = hostEnvironment.ContentRootPath;

            var applicationLifetime = (IHostApplicationLifetime)serviceProvider.GetService(typeof(IHostApplicationLifetime));
            this.applicationStoppingToken = applicationLifetime.ApplicationStopping;
        }

        /// <summary>
        /// Flag that indicates Emeraude app initialization.
        /// </summary>
        [HtmlAttributeName(EmeraudeAppAttributeName)]
        public bool ActivateEmeraude { get; set; }

        /// <summary>
        /// Specifies the path to the built application server bundle.
        /// </summary>
        [HtmlAttributeName(ServerBundleAttributeName)]
        public string ServerBundle { get; set; }

        /// <summary>
        /// The initial state model parameter that will be applied into the application store state.
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

        /// <inheritdoc/>
        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            try
            {
                if (this.ActivateEmeraude)
                {
                    output.Attributes.Add(new TagHelperAttribute("id", "emeraude-app"));

                    var result = await EmPageRenderer.RenderToString(
                            this.applicationBasePath,
                            this.nodeServices,
                            this.applicationStoppingToken,
                            this.ServerBundle,
                            this.ViewContext.HttpContext,
                            this.InitialStateViewModel,
                            this.TimeoutMillisecondsParameter);

                    if (!string.IsNullOrEmpty(result.RedirectUrl))
                    {
                        // It's a redirection
                        var permanentRedirect = result.StatusCode.GetValueOrDefault() == 301;
                        this.ViewContext.HttpContext.Response.Redirect(result.RedirectUrl, permanentRedirect);
                        return;
                    }

                    if (result.StatusCode.HasValue)
                    {
                        this.ViewContext.HttpContext.Response.StatusCode = result.StatusCode.Value;
                    }

                    output.Content.SetHtmlContent(result.Html);
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
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
            }
        }
#pragma warning restore 612, 618
    }
}