using System;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Admin
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
        /// Sets the type of the request used for administration dashboard index page.
        /// </summary>
        /// <typeparam name="TRequest">Type of the request.</typeparam>
        public void SetDashboardRequestType<TRequest>() => this.DashboardRequestType = typeof(TRequest);

        /// <summary>
        /// Set admin menus builder type.
        /// </summary>
        /// <typeparam name="TAdminMenusBuilder">Admin menus builder implementation type.</typeparam>
        public void SetAdminMenusBuilder<TAdminMenusBuilder>()
            where TAdminMenusBuilder : class, IAdminMenusBuilder
        {
            this.AdminMenusBuilderType = typeof(TAdminMenusBuilder);
        }
    }
}