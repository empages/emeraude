using System.Net.Http;

namespace Definux.Emeraude.Admin.EmPages.Schema
{
    /// <summary>
    /// Defines EmPage action.
    /// </summary>
    public class EmPageAction
    {
        /// <summary>
        /// Order of the action.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Name of the action.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Relative to main entity URL of the action. This property supports string placeholder {0} which is the entity identifier.
        /// </summary>
        public string RelativeUrlFormat { get; set; }

        /// <summary>
        /// Represents a flag that indicates whether the action be executed separately or not.
        /// </summary>
        public bool SingleContext { get; set; }

        /// <summary>
        /// Indicates whether the action opens directly a HTTP request or a separate page.
        /// </summary>
        public bool DirectRequest { get; set; }

        /// <summary>
        /// Execution method.
        /// </summary>
        public HttpMethod Method { get; set; } = HttpMethod.Get;

        /// <summary>
        /// Indicates whether the action requires confirmation.
        /// </summary>
        public bool HasConfirmation => string.IsNullOrWhiteSpace(this.ConfirmationMessage);

        /// <summary>
        /// Message for action confirmation.
        /// </summary>
        public string ConfirmationMessage { get; set; }

        /// <summary>
        /// Builds full action url.
        /// </summary>
        /// <param name="entityKey"></param>
        /// <returns></returns>
        public string BuildActionUrlFormat(string entityKey)
        {
            var urlBase = $"/admin/{entityKey}";
            var relativeUrl = this.RelativeUrlFormat ?? string.Empty;
            if (!relativeUrl.StartsWith("/"))
            {
                relativeUrl = "/" + relativeUrl;
            }

            if (relativeUrl.Equals("/"))
            {
                relativeUrl = string.Empty;
            }

            return $"{urlBase}{relativeUrl}";
        }
    }
}