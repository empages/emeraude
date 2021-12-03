using System;

namespace Emeraude.Application.Admin.EmPages.Exceptions
{
    /// <summary>
    /// Exception that is thrown when a user is not authorized to execute EmPage operation.
    /// </summary>
    public class EmPageAuthorizationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageAuthorizationException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public EmPageAuthorizationException(string message)
            : base(message)
        {
        }
    }
}