using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Renderers
{
    /// <summary>
    /// Renderer for HTML.
    /// </summary>
    public class EmPageHtmlRenderer : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageHtmlRenderer"/> class.
        /// </summary>
        public EmPageHtmlRenderer()
            : base(EmPageComponentType.Renderer)
        {
        }

        /// <summary>
        /// Flag that indicates whether the HTML is encoded or not.
        /// </summary>
        public bool Encoded { get; set; }
    }
}