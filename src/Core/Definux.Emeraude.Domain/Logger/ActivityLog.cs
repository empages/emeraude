using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Domain.Logging
{
    public class ActivityLog : LoggerEntity
    {
        public string Action { get; set; }

        public string Controller { get; set; }

        public string Area { get; set; }

        public string Parameters { get; set; }

        public string Headers { get; set; }

        public string Route { get; set; }

        public string Method { get; set; }

        public string TraceId { get; set; }

        public string UserAgent { get; set; }

        public bool IsFromMobileDevice
        {
            get
            {
                return UserAgent.IsUserAgentMobileDevice();
            }
        }

        public bool IsAuthenticatedUser
        {
            get
            {
                return !string.IsNullOrEmpty(CreatedBy);
            }
        }
    }
}
