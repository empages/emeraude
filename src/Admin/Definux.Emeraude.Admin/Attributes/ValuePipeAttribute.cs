using System;

namespace Definux.Emeraude.Admin.Attributes
{
    /// <summary>
    /// Attribute that convert the value that will be shown on the UI.
    /// </summary>
    [AttributeUsage(AttributeTargets.Property)]
    public class ValuePipeAttribute : Attribute
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ValuePipeAttribute"/> class.
        /// </summary>
        /// <param name="type"></param>
        /// <param name="order"></param>
        /// <param name="parameters"></param>
        public ValuePipeAttribute(Type type, int order, params string[] parameters)
        {
            this.Type = type;
            this.Order = order;
            this.Parameters = parameters;
        }

        /// <summary>
        /// Type of the pipe.
        /// </summary>
        public Type Type { get; set; }

        /// <summary>
        /// Order of the pipe.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Parameters of the pipe.
        /// </summary>
        public string[] Parameters { get; set; }
    }
}