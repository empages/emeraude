using System;

namespace Definux.Emeraude.Admin.EmPages.Exceptions
{
    /// <summary>
    /// Exception that is thrown when there is an invalid schema setup. Normally this exception is thrown during schema definition.
    /// </summary>
    public class EmPageInvalidSchemaDefinitionException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageInvalidSchemaDefinitionException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public EmPageInvalidSchemaDefinitionException(string message)
            : base(message)
        {
        }
    }
}