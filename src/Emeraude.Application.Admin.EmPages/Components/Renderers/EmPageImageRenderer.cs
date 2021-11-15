using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Renderers
{
    /// <summary>
    /// Renderer for images.
    /// </summary>
    public class EmPageImageRenderer : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageImageRenderer"/> class.
        /// </summary>
        public EmPageImageRenderer()
            : base(EmPageComponentType.Renderer)
        {
        }

        /// <summary>
        /// Width of the image.
        /// </summary>
        public string Width { get; set; }

        /// <summary>
        /// Height of the image.
        /// </summary>
        public string Height { get; set; }
    }
}