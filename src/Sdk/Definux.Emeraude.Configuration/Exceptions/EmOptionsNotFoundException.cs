using System;

namespace Definux.Emeraude.Configuration.Exceptions
{
    /// <summary>
    /// Represent error during accessing specific Emeraude options.
    /// </summary>
    public class EmOptionsNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmOptionsNotFoundException"/> class.
        /// </summary>
        public EmOptionsNotFoundException()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EmOptionsNotFoundException"/> class.
        /// </summary>
        /// <param name="message"></param>
        public EmOptionsNotFoundException(string message)
            : base(message)
        {
        }
    }
}