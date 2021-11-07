// using System;
// using System.Collections.Generic;
// using System.Threading.Tasks;
// using Definux.Emeraude.Application.Admin.EmPages.UI.Adapters;
// using Definux.Emeraude.Application.Admin.EmPages.UI.Models;
// using Definux.Emeraude.Application.Admin.EmPages.UI.Models.TableView;
// using Definux.Emeraude.Application.Admin.UI.Extensions;
// using Definux.Emeraude.Application.Admin.UI.Models;
// using Definux.Emeraude.Application.Admin.UI.Pages;
// using Microsoft.AspNetCore.Components;
// using Microsoft.AspNetCore.Components.Routing;
// using Microsoft.AspNetCore.WebUtilities;
// using Microsoft.Extensions.Primitives;
//
// namespace Definux.Emeraude.Application.Admin.EmPages.UI.Pages
// {
//     /// <summary>
//     /// Abstract implementation of EmPage.
//     /// </summary>
//     /// <typeparam name="TViewModel">EmPage view model.</typeparam>
//     public abstract class EmPage<TViewModel> : AdminPage
//         where TViewModel : EmPageViewModel
//     {
//         private string route;
//
//         /// <summary>
//         /// Route of the page.
//         /// </summary>
//         [Parameter]
//         public string Route { get; set; }
//
//         /// <inheritdoc cref="IEmPageManager"/>
//         [Inject]
//         protected IEmPageManager EmPageManager { get; set; }
//
//         /// <summary>
//         /// View model of the page.
//         /// </summary>
//         /// <returns></returns>
//         protected TViewModel ViewModel { get; set; }
//
//         /// <summary>
//         /// Title of the page.
//         /// </summary>
//         protected virtual string PageTitle => this.ViewModel?.Context.Title;
//
//         /// <inheritdoc/>
//         protected override IEnumerable<BreadcrumbItemModel> ConfigureBreadcrumbs()
//             => this.ViewModel?.Context.Breadcrumbs ?? new List<BreadcrumbItemModel>();
//
//         /// <inheritdoc/>
//         protected override IEnumerable<ActionModel> ConfigureNavigationActions()
//             => this.ViewModel?.Context.NavbarActions ?? new List<ActionModel>();
//
//         /// <summary>
//         /// Reset view model of the page.
//         /// </summary>
//         protected virtual void ResetViewModel()
//         {
//             this.ViewModel = null;
//             this.StateHasChanged();
//         }
//
//         /// <summary>
//         /// Retrieves the view model from the EmPage manager. Method is abstract so it must be configured manually.
//         /// </summary>
//         /// <returns></returns>
//         protected abstract Task<TViewModel> RetrieveViewModelAsync();
//
//         /// <summary>
//         /// Gets query params of current page.
//         /// </summary>
//         /// <returns></returns>
//         protected IDictionary<string, StringValues> GetQueryParameters()
//         {
//             var queryString = new Uri(this.NavigationManager.Uri).Query;
//             return QueryHelpers.ParseQuery(queryString);
//         }
//
//         /// <inheritdoc/>
//         protected override async Task OnInitializedAsync()
//         {
//             this.route = this.Route;
//             this.NavigationManager.LocationChanged += this.OnLocationChanged;
//             await this.ReloadPageAsync();
//         }
//
//         /// <inheritdoc/>
//         protected override async Task OnParametersSetAsync()
//         {
//             await base.OnParametersSetAsync();
//             if (!(this.route ?? string.Empty).Equals(this.Route, StringComparison.OrdinalIgnoreCase))
//             {
//                 this.route = this.Route;
//                 await this.ReloadPageAsync();
//             }
//         }
//
//         /// <inheritdoc/>
//         protected override async void OnLocationChanged(object sender, LocationChangedEventArgs e)
//         {
//             await this.ReloadPageAsync();
//         }
//
//         /// <summary>
//         /// Reload page view model. In case of non existing view model - redirects to 404.
//         /// </summary>
//         /// <returns></returns>
//         protected virtual async Task ReloadPageAsync()
//         {
//             this.ResetViewModel();
//             var viewModel = await this.RetrieveViewModelAsync();
//             if (viewModel == null)
//             {
//                 this.NavigationManager.NavigateToNotFoundPage();
//                 return;
//             }
//
//             this.ViewModel = viewModel;
//             this.StateHasChanged();
//         }
//     }
// }