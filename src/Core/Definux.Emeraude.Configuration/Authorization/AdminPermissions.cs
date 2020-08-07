using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Definux.Emeraude.Configuration.Authorization
{
    public static class AdminPermissions
    {
        public static ReadOnlyCollection<ApplicationPermission> AllPermissions;

        //Policies
        public const string AccessAdministrationPolicy = "Access Administration";
        public const string AccessErrorLogsPolicy = "Access Error Logs";
        public const string UsersManagementPolicy = "Users Management";
        public const string RootAccessPolicy = "Root Access";

        //Permissions
        public static ApplicationPermission AccessAdministration = new ApplicationPermission(AccessAdministrationPolicy);
        public static ApplicationPermission AccessErrorLogs = new ApplicationPermission(AccessErrorLogsPolicy);
        public static ApplicationPermission UsersManagement = new ApplicationPermission(UsersManagementPolicy);
        public static ApplicationPermission RootAccess = new ApplicationPermission(RootAccessPolicy);

        static AdminPermissions()
        {
            List<ApplicationPermission> allPermissions = new List<ApplicationPermission>()
            {
                AccessAdministration,
                AccessErrorLogs,
                UsersManagement,
                RootAccess,
            };

            AllPermissions = allPermissions.AsReadOnly();
        }

        public static ApplicationPermission GetPermissionByName(string permissionName)
        {
            return AllPermissions.Where(p => p.Name == permissionName).FirstOrDefault();
        }

        public static ApplicationPermission GetPermissionByValue(string permissionValue)
        {
            return AllPermissions.Where(p => p.Value == permissionValue).FirstOrDefault();
        }

        public static string[] GetAllPermissionValues()
        {
            return AllPermissions.Select(p => p.Value).ToArray();
        }
    }
}
