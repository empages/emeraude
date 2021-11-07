using Definux.Emeraude.Application.Admin.EmPages.Shared;

namespace Definux.Emeraude.Application.Admin.EmPages.Components.Renderers
{
    /// <summary>
    /// Renderer for enumerations.
    /// The default formatting function will split the words by capital letter.
    /// </summary>
    public class EmPageEnumRenderer : EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageEnumRenderer"/> class.
        /// </summary>
        public EmPageEnumRenderer()
            : base(EmPageComponentType.Renderer)
        {
        }
    }
}