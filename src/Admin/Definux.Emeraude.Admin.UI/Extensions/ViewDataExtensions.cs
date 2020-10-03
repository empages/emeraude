using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ViewDataDictionary"/>.
    /// </summary>
    public static class ViewDataExtensions
    {
        /// <summary>
        /// Breadcrumbs ViewData key.
        /// </summary>
        public const string BreadcrumbsKey = "Breadcrumbs";

        /// <summary>
        /// Navigation actions ViewData key.
        /// </summary>
        public const string NavigationActionsKey = "NavigationActions";

        /// <summary>
        /// Get the name of the area for the current request.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string GetArea(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("AreaName");
        }

        /// <summary>
        /// Get the name of the controller for the current request.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string GetController(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("ControllerName");
        }

        /// <summary>
        /// Get the name of the action for the current request.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string GetAction(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("ActionName");
        }

        /// <summary>
        /// Get the search query value from key 'SearchQuery'.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string GetSearchQuery(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("SearchQuery");
        }

        /// <summary>
        /// Save search query into ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <param name="value"></param>
        public static void SetSearchQuery(this ViewDataDictionary viewData, string value)
        {
            viewData["SearchQuery"] = value;
        }

        /// <summary>
        /// Get the name of the entity from key 'EntityName'.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static string GetEntityName(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("EntityName");
        }

        /// <summary>
        /// Set title to the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <param name="title"></param>
        /// <returns></returns>
        public static ViewDataDictionary SetTitle(this ViewDataDictionary viewData, string title)
        {
            viewData["Title"] = title;
            return viewData;
        }

        /// <summary>
        /// Initialize collection of breadcrumbs items of type <see cref="BreadcrumbItemViewModel"/>.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static ViewDataDictionary InitializeBreadcrumbs(this ViewDataDictionary viewData)
        {
            if (viewData[BreadcrumbsKey] == null)
            {
                viewData[BreadcrumbsKey] = new List<BreadcrumbItemViewModel>();
            }

            return viewData;
        }

        /// <summary>
        /// Add a breadcrumb into the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <param name="breadcrumb"></param>
        /// <returns></returns>
        public static ViewDataDictionary AddBreadcrumb(this ViewDataDictionary viewData, BreadcrumbItemViewModel breadcrumb)
        {
            if (viewData[BreadcrumbsKey] != null)
            {
                ((List<BreadcrumbItemViewModel>)viewData[BreadcrumbsKey]).Add(breadcrumb);
            }

            return viewData;
        }

        /// <summary>
        /// Get a breadcrumb from the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static List<BreadcrumbItemViewModel> GetBreadcrumbs(this ViewDataDictionary viewData)
        {
            if (viewData[BreadcrumbsKey] != null)
            {
                return (List<BreadcrumbItemViewModel>)viewData[BreadcrumbsKey];
            }

            return new List<BreadcrumbItemViewModel>();
        }

        /// <summary>
        /// Initialize collection of navigation actions of type <see cref="NavigationActionViewModel"/>.
        /// </summary>
        /// <param name="viewData"></param>
        /// <param name="actions"></param>
        /// <returns></returns>
        public static ViewDataDictionary InitializeNavigationActions(this ViewDataDictionary viewData, IEnumerable<NavigationActionViewModel> actions = null)
        {
            if (viewData[NavigationActionsKey] == null)
            {
                viewData[NavigationActionsKey] = actions?.ToList() ?? new List<NavigationActionViewModel>();
            }

            return viewData;
        }

        /// <summary>
        /// Add a navigation action into the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <param name="action"></param>
        /// <returns></returns>
        public static ViewDataDictionary AddNavigationAction(this ViewDataDictionary viewData, NavigationActionViewModel action)
        {
            if (viewData[NavigationActionsKey] != null)
            {
                ((List<NavigationActionViewModel>)viewData[NavigationActionsKey]).Add(action);
            }

            return viewData;
        }

        /// <summary>
        /// Get a navigation action from the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static List<NavigationActionViewModel> GetNavigationActions(this ViewDataDictionary viewData)
        {
            if (viewData[NavigationActionsKey] != null)
            {
                return (List<NavigationActionViewModel>)viewData[NavigationActionsKey];
            }

            return new List<NavigationActionViewModel>();
        }

        private static string GetStringValueOrDefault(this ViewDataDictionary viewData, string key)
        {
            return viewData.ContainsKey(key) ? viewData[key]?.ToString() : null;
        }
    }
}
