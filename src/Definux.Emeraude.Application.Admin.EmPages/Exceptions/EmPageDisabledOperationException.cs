using System;

namespace Definux.Emeraude.Application.Admin.EmPages.Exceptions
{
    /// <summary>
    /// Exception that is thrown when there is an attempt to a disabled operation.
    /// </summary>
    public class EmPageDisabledOperationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageDisabledOperationException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public EmPageDisabledOperationException(string message)
            : base(message)
        {
        }
    }
}