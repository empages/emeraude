using System;
using Definux.Emeraude.Application.Admin.Adapters;
using Definux.Emeraude.Configuration.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Definux.Emeraude.Application.Admin
{
    /// <summary>
    /// Options for admin part of Emeraude.
    /// </summary>
    public class EmAdminOptions : IEmOptions
    {
        /// <summary>
        /// Admin dashboard request type.
        /// </summary>
        public Type DashboardRequestType { get; set; }

        /// <summary>
        /// Implementation type of <see cref="IAdminMenusBuilder"/>.
        /// </summary>
        public Type AdminMenusBuilderType { get; set; }

        /// <summary>
        /// Set admin menus builder type.
        /// </summary>
        /// <typeparam name="TAdminMenusBuilder">Admin menus builder implementation type.</typeparam>
        public void SetAdminMenusBuilder<TAdminMenusBuilder>()
            where TAdminMenusBuilder : class, IAdminMenusBuilder
        {
            this.AdminMenusBuilderType = typeof(TAdminMenusBuilder);
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public void Validate()
        {
        }
    }
}