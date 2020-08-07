using Definux.Emeraude.Client.EmPages.Models;
using Definux.Emeraude.Presentation.Controllers;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;

namespace Definux.Emeraude.Client.EmPages.Abstractions
{
    public abstract class EmPage<TInitialStateModel, TInitialStateModelData, TRequest> : PublicController, IEmPage
        where TInitialStateModel : class, IInitialStateModel<TInitialStateModelData>, new()
        where TInitialStateModelData : class, IInitialStateModelData, new()
        where TRequest : class, IRequest<TInitialStateModelData>, new()
    {
        public TInitialStateModel InitialStateModel { get; protected set; }

        public TInitialStateModelData InitialStateModelData { get; protected set; }

        public TRequest InitialStateModelDataRequest { get; protected set; }

        [HttpGet]
        public virtual async Task<IActionResult> Index()
        {
            TInitialStateModel model = await BuildInitialStateModel();
            return EmPageView(model);
        }

        [HttpPost]
        public async Task<IActionResult> InitalStateDataRequest()
        {
            TInitialStateModel model = await BuildInitialStateModel();
            return this.Ok(model);
        }

        protected virtual async Task<TInitialStateModel> BuildInitialStateModel()
        {
            return await CreateInitialStateModelAsync(new TRequest());
        }

        protected async virtual Task<TInitialStateModel> CreateInitialStateModelAsync(IRequest<TInitialStateModelData> dataQuery)
        {
            TInitialStateModel model = new TInitialStateModel();

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

            model.Data = dataQuery is null ? null : await Mediator.Send(dataQuery);

            return model;
        }

        [NonAction]
        protected IActionResult EmPageView(IInitialStateModel<TInitialStateModelData> model)
        {
            return View("EmPages/Index", model);
        }


        [NonAction]
        protected void SetLayout(string layout)
        {
            ViewData["Layout"] = layout;
        }
    }
}
