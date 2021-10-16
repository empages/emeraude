using System;

namespace Definux.Emeraude.Admin.EmPages.Exceptions
{
    /// <summary>
    /// Exception for missing EmPage configuration.
    /// </summary>
    public class EmPageMissingConfigurationException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageMissingConfigurationException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public EmPageMissingConfigurationException(string message)
            : base(message)
        {
        }
    }
}