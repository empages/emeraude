using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.MobileSdk.Events
{
    /// <summary>
    /// Event args implementation for login completion event.
    /// </summary>
    public class LoginCompletedEventArgs : EventArgs
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="LoginCompletedEventArgs"/> class.
        /// </summary>
        /// <param name="succeeded"></param>
        public LoginCompletedEventArgs(bool succeeded)
        {
            this.Succeeded = succeeded;
        }

        /// <summary>
        /// Flag that indicates the success status of the login completion.
        /// </summary>
        public bool Succeeded { get; }
    }
}
