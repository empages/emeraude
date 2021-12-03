using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using Emeraude.Essentials.Models;

namespace Emeraude.Infrastructure.Identity.Common
{
    /// <summary>
    /// Built-in permissions of the Emeraude Framework.
    /// </summary>
    public static class EmPermissions
    {
        /// <summary>
        /// Access administration policy name.
        /// </summary>
        public const string AccessAdministrationPolicy = "Access Administration";

        static EmPermissions()
        {
            List<ApplicationPermission> allPermissions = new List<ApplicationPermission>()
            {
                AccessAdministration,
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
        /// Get permission from the list by its permission name.
        /// </summary>
        /// <param name="permissionName"></param>
        /// <returns></returns>
        public static ApplicationPermission GetPermissionByName(string permissionName)
        {
            return AllPermissions.FirstOrDefault(p => p.Name == permissionName);
        }

        /// <summary>
        /// Get permission from the list by its permission value.
        /// </summary>
        /// <param name="permissionValue"></param>
        /// <returns></returns>
        public static ApplicationPermission GetPermissionByValue(string permissionValue)
        {
            return AllPermissions.FirstOrDefault(p => p.Value == permissionValue);
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