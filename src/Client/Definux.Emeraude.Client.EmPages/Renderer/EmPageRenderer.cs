using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Http.Features;
using Microsoft.AspNetCore.NodeServices;

namespace Definux.Emeraude.Client.EmPages.Renderer
{
    /// <summary>
    /// Performs server-side Vue app prerendering by invoking code in Node.js.
    /// </summary>
    public static class EmPageRenderer
    {
        private const string RendererScriptPath = "/Content/Node/render-on-server.js";
        private const string RendererMainFunction = "renderToString";
        private static readonly object CreateNodeScriptLock = new object();
#pragma warning disable 612, 618
        private static StringAsTempFile nodeScript;

        /// <summary>
        /// Performs server-side EmPage prerendering by invoking code in Node.js.
        /// </summary>
        /// <param name="applicationBasePath"></param>
        /// <param name="nodeServices"></param>
        /// <param name="applicationStoppingToken"></param>
        /// <param name="serverBundlePath"></param>
        /// <param name="httpContext"></param>
        /// <param name="customDataParameter"></param>
        /// <param name="timeoutMilliseconds"></param>
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
                RendererMainFunction,
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
                if (nodeScript == null)
                {
                    var script = EmbeddedResourceReader.Read(typeof(EmPageRenderer), RendererScriptPath);
                    nodeScript = new StringAsTempFile(script, applicationStoppingToken);
                }
            }

            return nodeScript.FileName;
        }
#pragma warning restore 612, 618
    }
}
