using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;

namespace Definux.Emeraude.Configuration.Authorization
{
    /// <summary>
    /// Static class that provides administration permissions of the Emeraude.
    /// </summary>
    public static class AdminPermissions
    {
        /// <summary>
        /// Access administration policty name.
        /// </summary>
        public const string AccessAdministrationPolicy = "Access Administration";

        /// <summary>
        /// Access error logs policty name.
        /// </summary>
        public const string AccessErrorLogsPolicy = "Access Error Logs";

        /// <summary>
        /// Users management policty name.
        /// </summary>
        public const string UsersManagementPolicy = "Users Management";

        /// <summary>
        /// Root access policty name.
        /// </summary>
        public const string RootAccessPolicy = "Root Access";

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

        /// <summary>
        /// Readonly collection contains all permissions of the system.
        /// </summary>
        public static ReadOnlyCollection<ApplicationPermission> AllPermissions { get; }

        /// <summary>
        /// Access administration application permission.
        /// </summary>
        public static ApplicationPermission AccessAdministration { get; } = new ApplicationPermission(AccessAdministrationPolicy);

        /// <summary>
        /// Access error logs application permission.
        /// </summary>
        public static ApplicationPermission AccessErrorLogs { get; } = new ApplicationPermission(AccessErrorLogsPolicy);

        /// <summary>
        /// Users management application permission.
        /// </summary>
        public static ApplicationPermission UsersManagement { get; } = new ApplicationPermission(UsersManagementPolicy);

        /// <summary>
        /// Root access application permission.
        /// </summary>
        public static ApplicationPermission RootAccess { get; } = new ApplicationPermission(RootAccessPolicy);

        /// <summary>
        /// Get permission from the list by its permission name.
        /// </summary>
        /// <param name="permissionName"></param>
        /// <returns></returns>
        public static ApplicationPermission GetPermissionByName(string permissionName)
        {
            return AllPermissions.Where(p => p.Name == permissionName).FirstOrDefault();
        }

        /// <summary>
        /// Get permission from the list by its permission value.
        /// </summary>
        /// <param name="permissionValue"></param>
        /// <returns></returns>
        public static ApplicationPermission GetPermissionByValue(string permissionValue)
        {
            return AllPermissions.Where(p => p.Value == permissionValue).FirstOrDefault();
        }

        /// <summary>
        /// Get all permission values from all permissions.
        /// </summary>
        /// <returns></returns>
        public static string[] GetAllPermissionValues()
        {
            return AllPermissions.Select(p => p.Value).ToArray();
        }
    }
}