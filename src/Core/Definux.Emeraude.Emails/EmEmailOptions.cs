using System;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Emails
{
    /// <summary>
    /// Options for email infrastructure of Emeraude.
    /// </summary>
    public class EmEmailOptions : IEmOptions
    {
        /// <summary>
        /// Type of email service implementation. If null the default email provider will be registered.
        /// </summary>
        public Type EmailSenderImplementationType { get; set; }
    }
}