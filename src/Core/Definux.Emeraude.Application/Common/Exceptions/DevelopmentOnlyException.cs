using System;

namespace Definux.Emeraude.Application.Common.Exceptions
{
    /// <summary>
    /// Custom exception design for protection of actions and resources which must be unavailable outside of development environment.
    /// </summary>
    public class DevelopmentOnlyException : UnauthorizedAccessException
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopmentOnlyException"/> class.
        /// </summary>
        public DevelopmentOnlyException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DevelopmentOnlyException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public DevelopmentOnlyException(string message)
            : base(message)
        {
        }
    }
}
