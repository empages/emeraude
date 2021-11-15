using System;

namespace Emeraude.Infrastructure.Exceptions
{
    /// <summary>
    /// Exception that is thrown when an unexpected error occured in the infrastructure layer.
    /// </summary>
    public class InfrastructureImplementationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureImplementationException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public InfrastructureImplementationException(string message)
            : base(message)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="InfrastructureImplementationException"/> class.
        /// </summary>
        public InfrastructureImplementationException()
        {
        }
    }
}