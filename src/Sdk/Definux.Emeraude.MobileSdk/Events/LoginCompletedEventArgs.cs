using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.MobileSdk.Events
{
    public class LoginCompletedEventArgs : EventArgs
    {
        public LoginCompletedEventArgs(bool succeeded)
        {
            Succeeded = succeeded;
        }

        public bool Succeeded { get; }
    }
}
