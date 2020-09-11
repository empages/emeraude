using Definux.Emeraude.Client.EmPages.Models;
using Definux.Emeraude.Presentation.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.EmPages.Abstractions
{
    public abstract class EmPage<TViewModel, TRequest> : PublicController, IEmPage
        where TViewModel : class, IEmViewModel, new()
        where TRequest : class, IRequest<TViewModel>, new()
    {
        public InitialStateModel<TViewModel> InitialStateModel { get; protected set; }

        public TViewModel ViewModel { get; protected set; }

        public TRequest InitialStateRequest { get; protected set; }

        [HttpGet]
        public virtual async Task<IActionResult> Index()
        {
            var model = await BuildInitialStateModel();
            return EmPageView(model);
        }

        [HttpPost]
        public async Task<IActionResult> RequestInitialState()
        {
            var model = await BuildInitialStateModel();
            return this.Ok(model);
        }

        protected virtual async Task<InitialStateModel<TViewModel>> BuildInitialStateModel()
        {
            return await CreateInitialStateModelAsync(new TRequest());
        }

        protected async virtual Task<InitialStateModel<TViewModel>> CreateInitialStateModelAsync(IRequest<TViewModel> dataQuery)
        {
            var model = new InitialStateModel<TViewModel>(this.GetType().Name);

            var currentLanguage = await CurrentLanguageProvider.GetCurrentLanguageAsync();
            var currentUser = await CurrentUserProvider.GetCurrentUserAsync();

            model.User.IsAuthenticated = User.Identity.IsAuthenticated;
            
            model.LanguageCode = currentLanguage?.Code;
            model.LanguageId = currentLanguage?.Id ?? -1;

            if (model.User.IsAuthenticated && currentUser != null)
            {
                model.User.Roles = User.Claims.Where(x => x.Type == ClaimTypes.Role).Select(x => x.Value).ToArray();
                model.User.Email = currentUser.Email;
                model.User.Name = currentUser.Name;
            }

            model.ViewModel = dataQuery is null ? null : await Mediator.Send(dataQuery);

            var viewDataItems = await InitializeViewDataAsync(model);
            if (viewDataItems != null && viewDataItems.Count > 0)
            {
                foreach (var item in viewDataItems)
                {
                    model.AddViewDataItem(item.Key, item.Value);
                }
            }

            return model;
        }

        [NonAction]
        protected IActionResult EmPageView(InitialStateModel<TViewModel> model)
        {
            return View("EmPages/Index", model);
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
