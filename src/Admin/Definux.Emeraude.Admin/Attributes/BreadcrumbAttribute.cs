using System.Linq;
using Definux.Emeraude.Admin.UI.Extensions;
using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Definux.Emeraude.Presentation.Controllers;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Routing;

namespace Definux.Emeraude.Admin.Attributes
{
    /// <summary>
    /// Attribute that add filled data as a breadcrumb item.
    /// </summary>
    public class BreadcrumbAttribute : ActionFilterAttribute
    {
        private string title;
        private string controller;
        private string action;
        private string parameterName;
        private string parameterValue;
        private int order;
        private bool active;

        /// <summary>
        /// Initializes a new instance of the <see cref="BreadcrumbAttribute"/> class.
        /// </summary>
        /// <param name="title">Title text in the breadcrumb. Use "[SomeKey]" to add custom title based on the route. The key must be part of the ViewData collection.</param>
        /// <param name="active"></param>
        /// <param name="order"></param>
        /// <param name="action"></param>
        /// <param name="controller"></param>
        /// <param name="parameterName"></param>
        /// <param name="parameterValue"></param>
        public BreadcrumbAttribute(string title, bool active, int order, string action = null, string controller = null, string parameterName = null, string parameterValue = null)
        {
            this.title = title;
            this.active = active;
            this.action = action;
            this.controller = controller;
            this.order = order;
            this.parameterName = parameterName;
            this.parameterValue = parameterValue;
        }

        /// <summary>
        /// Route key that represent the parent reference.
        /// </summary>
        public string ParentRouteKey { get; set; }

        /// <summary>
        /// To use this property the caller controller must inherit <see cref="IChildController"/>.
        /// </summary>
        public bool UseParentController { get; set; }

        /// <inheritdoc/>
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var controller = (Controller)context.Controller;
            controller.ViewData.InitializeBreadcrumbs();

            if (this.active && !string.IsNullOrEmpty(this.action) && string.IsNullOrEmpty(this.controller))
            {
                this.controller = ((Controller)context.Controller).GetType().Name.Replace("Controller", string.Empty);
            }

            string parentRouteKey = null;
            string parentRouteValue = null;

            if (!string.IsNullOrEmpty(this.ParentRouteKey) && context.Controller.GetType().GetProperties().Any(x => x.Name == this.ParentRouteKey))
            {
                parentRouteKey = context
                    .Controller
                    .GetType()
                    .GetProperty(this.ParentRouteKey)
                    .GetValue(context.Controller)?
                    .ToString();

                if (!string.IsNullOrEmpty(parentRouteKey))
                {
                    parentRouteValue = context.HttpContext.GetRouteValue(parentRouteKey)?.ToString();
                }
            }

            if (this.UseParentController)
            {
                this.controller = ((IChildController)context.Controller).ParentController.Replace("Controller", string.Empty);
            }

            var currentBreadcrumb = new BreadcrumbItemViewModel(context)
            {
                Title = this.title,
                Controller = this.controller,
                Action = this.action,
                ParameterName = this.parameterName,
                ParameterValue = this.parameterValue,
                Order = this.order,
                Active = this.active,
                ParentReferenceKey = parentRouteKey,
                ParentReferenceValue = parentRouteValue,
            };

            controller.ViewData.AddBreadcrumb(currentBreadcrumb);

            base.OnActionExecuting(context);
        }
    }
}
