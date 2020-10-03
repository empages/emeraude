using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Routing;

namespace Definux.Emeraude.Admin.UI.ViewModels.Layout
{
    /// <summary>
    /// Implementation of a breadcrumb item.
    /// </summary>
    public class BreadcrumbItemViewModel
    {
        /// <summary>
        /// Breadcrumb ViewData key.
        /// </summary>
        public const string BreadcrumbKey = "Breadcrumb";

        private readonly IUrlHelper urlHelper;

        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbItemViewModel"/> class.
        /// </summary>
        /// <param name="context"></param>
        public BreadcrumbItemViewModel(ActionExecutingContext context)
        {
            this.urlHelper = new UrlHelperFactory().GetUrlHelper(context);
        }

        /// <summary>
        /// Title of the breadcrumb.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Controller that builds the breadcrumb action link.
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Action that builds the breadcrumb action link.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Additional parameter name for the breadcrumb action link.
        /// </summary>
        public string ParameterName { get; set; }

        /// <summary>
        /// Additional parameter value for the breadcrumb action link.
        /// </summary>
        public string ParameterValue { get; set; }

        /// <summary>
        /// In case breadcrumb is called from child controller that property defines the parent controller entity reference key.
        /// </summary>
        public string ParentReferenceKey { get; set; }

        /// <summary>
        /// In case breadcrumb is called from child controller that property defines the parent controller entity reference value.
        /// </summary>
        public string ParentReferenceValue { get; set; }

        /// <summary>
        /// Action link of the breadcrumb.
        /// </summary>
        public string ActionLink
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Controller) && !string.IsNullOrEmpty(this.Action))
                {
                    RouteValueDictionary parametersObject = new RouteValueDictionary();
                    if (!string.IsNullOrEmpty(this.ParameterName) && !string.IsNullOrEmpty(this.ParameterValue))
                    {
                        parametersObject[this.ParameterName] = this.ParameterValue;
                    }

                    if (!string.IsNullOrEmpty(this.ParentReferenceKey) && !string.IsNullOrEmpty(this.ParentReferenceValue))
                    {
                        parametersObject[this.ParentReferenceKey] = this.ParentReferenceValue;
                    }

                    return this.urlHelper.Action(this.Action, this.Controller, parametersObject);
                }

                return string.Empty;
            }
        }

        /// <summary>
        /// Order of the breadcrumb.
        /// </summary>
        public int Order { get; set; }

        /// <summary>
        /// Flag that shows the active status of the breadcrumb.
        /// </summary>
        public bool Active { get; set; }
    }
}
