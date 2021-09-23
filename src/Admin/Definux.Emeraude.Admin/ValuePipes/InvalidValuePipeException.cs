using System;

namespace Definux.Emeraude.Admin.ValuePipes
{
    /// <summary>
    /// Exception for the cases where the pipe setup is invalid.
    /// </summary>
    public class InvalidValuePipeException : InvalidCastException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidValuePipeException"/> class.
        /// </summary>
        public InvalidValuePipeException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InvalidValuePipeException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public InvalidValuePipeException(string message)
            : base(message)
        {
        }
    }
}