using System;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Configuration.Options;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Definux.Emeraude.Admin
{
    /// <summary>
    /// Options for admin part of Emeraude.
    /// </summary>
    public class EmAdminOptions : IEmOptions
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmAdminOptions"/> class.
        /// </summary>
        public EmAdminOptions()
        {
            this.LocalJsonSerializerSettings = new JsonSerializerSettings()
            {
                ContractResolver = new DefaultContractResolver
                {
                    NamingStrategy = new CamelCaseNamingStrategy(),
                },
                Formatting = Formatting.Indented,
            };
        }

        /// <summary>
        /// Admin dashboard request type.
        /// </summary>
        public Type DashboardRequestType { get; set; }

        /// <summary>
        /// Implementation type of <see cref="IAdminMenusBuilder"/>.
        /// </summary>
        public Type AdminMenusBuilderType { get; set; }

        /// <summary>
        /// JSON serializer settings for local admin operations with the Web API.
        /// </summary>
        public JsonSerializerSettings LocalJsonSerializerSettings { get; set; }

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

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public void Validate()
        {
        }
    }
}