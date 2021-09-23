using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    /// <summary>
    /// Extensions for models.
    /// </summary>
    public static class ModelsExtensions
    {
        /// <summary>
        /// Get pagination href.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="page"></param>
        /// <param name="viewData"></param>
        /// <param name="urlHelper"></param>
        /// <returns></returns>
        public static string GetPaginationHref(this TablePaginationViewModel model, int? page, ViewDataDictionary viewData, IUrlHelper urlHelper)
        {
            if (model.AdditionalQueryParams == null)
            {
                return urlHelper.Action(viewData.GetAction(), viewData.GetController(), new
                {
                    Area = viewData.GetArea(),
                    page = page,
                    searchQuery = viewData.GetSearchQuery(),
                    orderBy = viewData.GetOrderProperty(),
                    orderType = viewData.GetOrderType(),
                });
            }
            else
            {
                model.AdditionalQueryParams["page"] = page;
                model.AdditionalQueryParams["Area"] = viewData.GetArea();
                return urlHelper.Action(viewData.GetAction(), viewData.GetController(), model.AdditionalQueryParams);
            }
        }
    }
}