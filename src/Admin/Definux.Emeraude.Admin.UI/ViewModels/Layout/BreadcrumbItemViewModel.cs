using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

namespace Definux.Emeraude.Admin.UI.ViewModels.Layout
{
    public class BreadcrumbItemViewModel
    {
        public const string BreadcrumbKey = "Breadcrumb";

        private readonly IUrlHelper urlHelper;

        public BreadcrumbItemViewModel(ActionExecutingContext context)
        {
            this.urlHelper = new UrlHelperFactory().GetUrlHelper(context);
        }

        public string Title { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public string ParameterName { get; set; }

        public string ParameterValue { get; set; }

        public string ParentReferenceKey { get; set; }

        public string ParentReferenceValue { get; set; }

        public string ActionLink
        {
            get
            {
                if (!string.IsNullOrEmpty(Controller) && !string.IsNullOrEmpty(Action))
                {
                    RouteValueDictionary parametersObject = new RouteValueDictionary();
                    if (!string.IsNullOrEmpty(ParameterName) && !string.IsNullOrEmpty(ParameterValue))
                    {
                        parametersObject[ParameterName] = ParameterValue;

                    }

                    if (!string.IsNullOrEmpty(ParentReferenceKey) && !string.IsNullOrEmpty(ParentReferenceValue))
                    {
                        parametersObject[ParentReferenceKey] = ParentReferenceValue;
                    }

                    return this.urlHelper.Action(Action, Controller, parametersObject);
                }
                return string.Empty;

            }
        }

        public int Order { get; set; }

        public bool Active { get; set; }
    }
}
