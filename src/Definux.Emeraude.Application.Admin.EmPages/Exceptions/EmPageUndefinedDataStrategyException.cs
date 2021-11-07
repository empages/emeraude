using System;

namespace Definux.Emeraude.Application.Admin.EmPages.Exceptions
{
    /// <summary>
    /// Exception that is thrown when a specified data manager has not definition for its data strategy.
    /// </summary>
    public class EmPageUndefinedDataStrategyException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageUndefinedDataStrategyException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public EmPageUndefinedDataStrategyException(string message)
            : base(message)
        {
        }
    }
}