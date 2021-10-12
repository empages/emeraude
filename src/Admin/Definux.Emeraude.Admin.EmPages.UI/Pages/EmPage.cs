using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.UI.Adapters;
using Definux.Emeraude.Admin.EmPages.UI.Models.TableView;
using Definux.Emeraude.Admin.UI.Pages;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Routing;
using Microsoft.AspNetCore.WebUtilities;
using Microsoft.Extensions.Primitives;

namespace Definux.Emeraude.Admin.EmPages.UI.Pages
{
    /// <summary>
    /// Abstract implementation of admin page.
    /// </summary>
    public abstract class EmPage : AdminPage
    {
        private string route;

        /// <summary>
        /// Route of the page.
        /// </summary>
        [Parameter]
        public string Route { get; set; }

        /// <inheritdoc cref="IEmPageSchemaProvider"/>
        [Inject]
        protected IEmPageSchemaProvider SchemaProvider { get; set; }

        /// <inheritdoc cref="IEmPageDataService"/>
        [Inject]
        protected IEmPageDataService DataService { get; set; }

        /// <summary>
        /// Gets query params of current page.
        /// </summary>
        /// <returns></returns>
        protected IDictionary<string, StringValues> GetQueryParameters()
        {
            var queryString = new Uri(this.NavigationManager.Uri).Query;
            return QueryHelpers.ParseQuery(queryString);
        }

        /// <inheritdoc/>
        protected override async Task OnInitializedAsync()
        {
            this.route = this.Route;
            this.NavigationManager.LocationChanged += this.OnLocationChanged;
            await this.ReloadPageAsync();
        }

        /// <inheritdoc/>
        protected override async Task OnParametersSetAsync()
        {
            await base.OnParametersSetAsync();
            if (!(this.route ?? string.Empty).Equals(this.Route, StringComparison.OrdinalIgnoreCase))
            {
                this.route = this.Route;
                await this.ReloadPageAsync();
            }
        }

        /// <inheritdoc/>
        protected override async void OnLocationChanged(object sender, LocationChangedEventArgs e)
        {
            await this.ReloadPageAsync();
        }

        /// <summary>
        /// Reload page schema, data and the details.
        /// </summary>
        /// <returns></returns>
        protected abstract Task ReloadPageAsync();
    }
}