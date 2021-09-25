using System;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Class that contains specified property args of <see cref="IEmPageModel"/>.
    /// </summary>
    public class EmPageModelPropertyArgs
    {
        /// <summary>
        /// Name of the property that defines the item.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Type of the property that defines the item.
        /// </summary>
        public Type Type { get; set; }
    }
}