using System.Collections.Generic;
using System.Reflection;
using Definux.Emeraude.Admin.ValuePipes;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Implementation helper model that contains property info and its corresponding value pipes.
    /// </summary>
    public class PropertyValuePipes
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PropertyValuePipes"/> class.
        /// </summary>
        public PropertyValuePipes()
        {
            this.ValuePipes = new List<(IValuePipe, string[])>();
        }

        /// <summary>
        /// Target property name.
        /// </summary>
        public string PropertyName { get; set; }

        /// <summary>
        /// Value pipes and corresponding parameters that must be applied to the property.
        /// </summary>
        public IList<(IValuePipe, string[])> ValuePipes { get; set; }
    }
}