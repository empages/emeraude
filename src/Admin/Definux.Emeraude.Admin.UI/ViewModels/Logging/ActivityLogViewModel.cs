namespace Definux.Emeraude.Admin.UI.ViewModels.Logging
{
    /// <summary>
    /// View model that encapsulate activity log.
    /// </summary>
    public class ActivityLogViewModel : LogEntityViewModel
    {
        /// <summary>
        /// Name of the requested controller action.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// Name of the requested controller.
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Name of the requested controller area.
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// List represent as a string for all request parameters.
        /// </summary>
        public string Parameters { get; set; }

        /// <summary>
        /// List represent as a string for all request headers.
        /// </summary>
        public string Headers { get; set; }

        /// <summary>
        /// Current request route.
        /// </summary>
        public string Route { get; set; }

        /// <summary>
        /// Current request HTTP method.
        /// </summary>
        public string Method { get; set; }

        /// <summary>
        /// Unique string that unify each user.
        /// </summary>
        public string TraceId { get; set; }

        /// <summary>
        /// Current request user agent.
        /// </summary>
        public string UserAgent { get; set; }

        /// <summary>
        /// Flag that indicates whether the request is made from mobile device.
        /// </summary>
        public bool IsFromMobileDevice { get; set; }

        /// <summary>
        /// Flag that indicates whether the request is made from authenticated user.
        /// </summary>
        public bool IsAuthenticatedUser { get; set; }
    }
}