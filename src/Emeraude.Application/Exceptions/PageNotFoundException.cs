using System;

namespace Emeraude.Application.Exceptions
{
    /// <summary>
    /// Exception for showing the lack of accessed entity.
    /// </summary>
    public class PageNotFoundException : Exception
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PageNotFoundException"/> class.
        /// </summary>
        public PageNotFoundException()
            : base()
        {
        }
    }
}
