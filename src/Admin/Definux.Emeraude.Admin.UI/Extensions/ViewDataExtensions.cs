using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.Extensions
{
    public static class ViewDataExtensions
    {
        public const string BreadcrumbsKey = "Breadcrumbs";
        public const string NavigationActionsKey = "NavigationActions";

        public static string GetArea(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("AreaName");
        }

        public static string GetController(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("ControllerName");
        }

        public static string GetAction(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("ActionName");
        }

        public static string GetSearchQuery(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("SearchQuery");
        }

        public static void SetSearchQuery(this ViewDataDictionary viewData, string value)
        {
            viewData["SearchQuery"] = value;
        }

        public static string GetEntityName(this ViewDataDictionary viewData)
        {
            return viewData.GetStringValueOrDefault("EntityName");
        }

        public static ViewDataDictionary SetTitle(this ViewDataDictionary viewData, string title)
        {
            viewData["Title"] = title;
            return viewData;
        }

        public static ViewDataDictionary InitializeBreadcrumbs(this ViewDataDictionary viewData)
        {
            if (viewData[BreadcrumbsKey] == null)
            {
                viewData[BreadcrumbsKey] = new List<BreadcrumbItemViewModel>();
            }

            return viewData;
        }

        public static ViewDataDictionary AddBreadcrumb(this ViewDataDictionary viewData, BreadcrumbItemViewModel breadcrumb)
        {
            if (viewData[BreadcrumbsKey] != null)
            {
                ((List<BreadcrumbItemViewModel>)viewData[BreadcrumbsKey]).Add(breadcrumb);
            }

            return viewData;
        }

        public static List<BreadcrumbItemViewModel> GetBreadcrumbs(this ViewDataDictionary viewData)
        {
            if (viewData[BreadcrumbsKey] != null)
            {
                return (List<BreadcrumbItemViewModel>)viewData[BreadcrumbsKey];
            }

            return new List<BreadcrumbItemViewModel>();
        }

        public static ViewDataDictionary InitializeNavigationActions(this ViewDataDictionary viewData, IEnumerable<NavigationActionViewModel> actions = null)
        {
            if (viewData[NavigationActionsKey] == null)
            {
                viewData[NavigationActionsKey] = actions?.ToList() ?? new List<NavigationActionViewModel>();
            }

            return viewData;
        }

        public static ViewDataDictionary AddNavigationAction(this ViewDataDictionary viewData, NavigationActionViewModel action)
        {
            if (viewData[NavigationActionsKey] != null)
            {
                ((List<NavigationActionViewModel>)viewData[NavigationActionsKey]).Add(action);
            }

            return viewData;
        }

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
