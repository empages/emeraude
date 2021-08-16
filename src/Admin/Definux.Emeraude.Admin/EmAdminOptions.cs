using System;
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
        /// Sets the type of the request used for administration dashboard index page.
        /// </summary>
        /// <typeparam name="TRequest">Type of the request.</typeparam>
        public void SetDashboardRequestType<TRequest>() => this.DashboardRequestType = typeof(TRequest);
    }
}