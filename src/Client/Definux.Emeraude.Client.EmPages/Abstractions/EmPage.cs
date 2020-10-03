using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Definux.Emeraude.Client.EmPages.Models;
using Definux.Emeraude.Presentation.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Client.EmPages.Abstractions
{
    /// <summary>
    /// EmPage parent class that initialize a ASP.NET Core MVC page related with Vue.js page with custom predefined initial state.
    /// </summary>
    /// <typeparam name="TViewModel">Type of the returning data transfer object (ViewModel).</typeparam>
    /// <typeparam name="TRequest">Request that compute and return the ViewModel.</typeparam>
    public abstract class EmPage<TViewModel, TRequest> : PublicController, IEmPage
        where TViewModel : class, IEmViewModel, new()
        where TRequest : class, IRequest<TViewModel>, new()
    {
        /// <inheritdoc cref="IInitialStateModel{TViewModel}"/>
        public InitialStateModel<TViewModel> InitialStateModel { get; protected set; }

        /// <summary>
        /// Data transfer object for pass strong-typed data to the initial state of the page.
        /// </summary>
        public TViewModel ViewModel { get; protected set; }

        /// <summary>
        /// Request that compute and return the <see cref="ViewModel"/>.
        /// </summary>
        public TRequest InitialStateRequest { get; protected set; }

        /// <summary>
        /// GET request that returns the <see cref="EmPageView(InitialStateModel{TViewModel})"/> with the page initial state.
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public virtual async Task<IActionResult> Index()
        {
            var model = await this.BuildInitialStateModel();
            return this.EmPageView(model);
        }

        /// <summary>
        /// POST request for the page initial state without HTML rendering.
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public virtual async Task<IActionResult> RequestInitialState()
        {
            var model = await this.BuildInitialStateModel();
            return this.Ok(model);
        }

        /// <summary>
        /// Method that contains the implementation of creation of initial state model. It is usefull if you want to pass some routing data to the page ViewModel request.
        /// </summary>
        /// <returns></returns>
        protected virtual async Task<InitialStateModel<TViewModel>> BuildInitialStateModel()
        {
            return await this.CreateInitialStateModelAsync(new TRequest());
        }

        /// <summary>
        /// Method that create the initial state model - the customized data + all generic data. Overriding is not recommended.
        /// </summary>
        /// <param name="dataQuery"></param>
        /// <returns></returns>
        protected async virtual Task<InitialStateModel<TViewModel>> CreateInitialStateModelAsync(IRequest<TViewModel> dataQuery)
        {
            var model = new InitialStateModel<TViewModel>(this.GetType().Name);

            var currentLanguage = await this.CurrentLanguageProvider.GetCurrentLanguageAsync();
            var currentUser = await this.CurrentUserProvider.GetCurrentUserAsync();

            model.User.IsAuthenticated = this.User.Identity.IsAuthenticated;
            model.LanguageCode = currentLanguage?.Code;
            model.LanguageId = currentLanguage?.Id ?? -1;

            if (model.User.IsAuthenticated && currentUser != null)
            {
                model.User.Roles = this.User.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value).ToArray();
                model.User.Email = currentUser.Email;
                model.User.Name = currentUser.Name;
            }

            model.ViewModel = dataQuery is null ? null : await this.Mediator.Send(dataQuery);

            var viewDataItems = await this.InitializeViewDataAsync(model);
            if (viewDataItems != null && viewDataItems.Count > 0)
            {
                foreach (var item in viewDataItems)
                {
                    model.AddViewDataItem(item.Key, item.Value);
                }
            }

            return model;
        }

        /// <summary>
        /// Method that returns the action result of the EmPage. To work properly the existance of Views/Client/Shared/EmPages/Index.cshtml is a must.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        [NonAction]
        protected IActionResult EmPageView(InitialStateModel<TViewModel> model)
        {
            return this.View("EmPages/Index", model);
        }

        /// <summary>
        /// This method initializes the key-value pair used as view data for the initial state after the page view model is computed but before the page sending action result to the view.
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        protected async virtual Task<Dictionary<string, object>> InitializeViewDataAsync(InitialStateModel<TViewModel> model)
        {
            return new Dictionary<string, object>();
        }
    }
}
