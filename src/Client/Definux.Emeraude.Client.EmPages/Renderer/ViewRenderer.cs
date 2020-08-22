using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.NodeServices;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.EmPages.Renderer
{
    /// <summary>
    /// Performs server-side Vue app prerendering by invoking code in Node.js.
    /// </summary>
    public static class ViewRenderer
    {
#pragma warning disable 612, 618
        private static readonly object CreateNodeScriptLock = new object();

        private static StringAsTempFile NodeScript;

        /// <summary>
        /// Performs server-side prerendering by invoking code in Node.js.
        /// </summary>
        /// <param name="applicationBasePath">The root path to your application. This is used when resolving project-relative paths.</param>
        /// <param name="nodeServices">The instance of <see cref="INodeServices"/> that will be used to invoke JavaScript code.</param>
        /// <param name="applicationStoppingToken">A token that indicates when the host application is stopping.</param>
        /// <param name="bootModule">The path to the JavaScript file containing the prerendering logic.</param>
        /// <param name="requestAbsoluteUrl">The URL of the currently-executing HTTP request. This is supplied to the prerendering code.</param>
        /// <param name="requestPathAndQuery">The path and query part of the URL of the currently-executing HTTP request. This is supplied to the prerendering code.</param>
        /// <param name="customDataParameter">An optional JSON-serializable parameter to be supplied to the prerendering code.</param>
        /// <param name="timeoutMilliseconds">The maximum duration to wait for prerendering to complete.</param>
        /// <param name="requestPathBase">The PathBase for the currently-executing HTTP request.</param>
        /// <returns></returns>
        public static async Task<RenderToStringResult> RenderToString(
            string applicationBasePath,
            INodeServices nodeServices,
            CancellationToken applicationStoppingToken,
            string serverBundlePath,
            HttpContext httpContext,
            object customDataParameter,
            int timeoutMilliseconds)
        {
            var requestFeature = httpContext.Features.Get<IHttpRequestFeature>();
            var unencodedPathAndQuery = requestFeature.RawTarget;

            var request = httpContext.Request;
            var unencodedAbsoluteUrl = $"{request.Scheme}://{request.Host}{unencodedPathAndQuery}";

            var renderResult = await nodeServices.InvokeExportAsync<RenderToStringResult>(
                GetNodeScriptFilename(applicationStoppingToken),
                "renderToString",
                serverBundlePath,
                applicationBasePath,
                unencodedAbsoluteUrl,
                unencodedPathAndQuery,
                customDataParameter,
                timeoutMilliseconds,
                request.PathBase.ToString());

            return renderResult;
        }

        private static string GetNodeScriptFilename(CancellationToken applicationStoppingToken)
        {
            lock (CreateNodeScriptLock)
            {
                if (NodeScript == null)
                {
                    var script = EmbeddedResourceReader.Read(typeof(ViewRenderer), "/Content/Node/render-on-server.js");
                    NodeScript = new StringAsTempFile(script, applicationStoppingToken); // Will be cleaned up on process exit
                }
            }

            return NodeScript.FileName;
        }
#pragma warning restore 612, 618
    }
}
