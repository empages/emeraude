using System;
using System.Collections.Generic;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Infrastructure.Identity.ExternalProviders;
using Microsoft.AspNetCore.Identity;

namespace Definux.Emeraude.Infrastructure.Identity.Options
{
    /// <summary>
    /// Options for identity infrastructure of Emeraude.
    /// </summary>
    public class EmIdentityOptions : IEmOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmIdentityOptions"/> class.
        /// </summary>
        public EmIdentityOptions()
        {
            this.AdditionalRoles = new Dictionary<string, string[]>();
            this.ExternalProvidersAuthenticators = new List<IExternalProviderAuthenticator>();
            this.SourceIdentityOptions = new IdentityOptions();
            this.SetDefaults();
        }

        /// <summary>
        /// Flag that indicates whether to be registered external authentication from the settings.
        /// </summary>
        public bool HasExternalAuthentication { get; set; }

        /// <summary>
        /// Dictionary that contains all additional roles and their claims.
        /// </summary>
        public Dictionary<string, string[]> AdditionalRoles { get; set; }

        /// <summary>
        /// Internal options for identity management of ASP.NET.
        /// </summary>
        public IdentityOptions SourceIdentityOptions { get; set; }

        /// <summary>
        /// Collection of all external provider authenticators implementations used in the framework.
        /// </summary>
        public List<IExternalProviderAuthenticator> ExternalProvidersAuthenticators { get; }

        /// <summary>
        /// Seconds that indicate the valid time of the access token. Default is 900 (15 minutes).
        /// </summary>
        public int AccessTokenExpiration { get; set; } = 900;

        /// <summary>
        /// Seconds that indicate the valid time of the refresh token. Default is 31536000 (365 days).
        /// </summary>
        public int RefreshTokenExpiration { get; set; } = 31536000;

        /// <summary>
        /// Add additional role to the roles of the system. It is prefered to be added before first initialization of the system.
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="claims"></param>
        public void AddRole(string roleName, string[] claims)
        {
            this.AdditionalRoles[roleName] = claims;
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public void Validate()
        {
        }

        private void SetDefaults()
        {
            this.SourceIdentityOptions.User.RequireUniqueEmail = true;
            this.SourceIdentityOptions.Password.RequireDigit = true;
            this.SourceIdentityOptions.Password.RequiredLength = EmIdentityConstants.PasswordRequiredLength;
            this.SourceIdentityOptions.Password.RequireNonAlphanumeric = false;
            this.SourceIdentityOptions.Password.RequireUppercase = false;
            this.SourceIdentityOptions.Password.RequireLowercase = false;
            this.SourceIdentityOptions.Lockout.DefaultLockoutTimeSpan = TimeSpan.FromMinutes(EmIdentityConstants.DefaultLockoutTimeSpanMinutes);
            this.SourceIdentityOptions.Lockout.MaxFailedAccessAttempts = EmIdentityConstants.MaxFailedAccessAttempts;
            this.SourceIdentityOptions.SignIn.RequireConfirmedEmail = true;
            this.SourceIdentityOptions.SignIn.RequireConfirmedAccount = true;
        }
    }
}