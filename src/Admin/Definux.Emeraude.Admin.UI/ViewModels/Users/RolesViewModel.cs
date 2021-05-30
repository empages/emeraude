using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Definux.Emeraude.Admin.UI.ViewModels.Users
{
    /// <summary>
    /// View model for role assignment feature.
    /// </summary>
    public class RolesViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RolesViewModel"/> class.
        /// </summary>
        public RolesViewModel()
        {
            this.RoleOptions = new List<RoleOption>();
            this.SelectedRoles = new List<Guid>();
        }

        /// <summary>
        /// List of all roles in the application.
        /// </summary>
        [BindNever]
        public List<RoleOption> RoleOptions { get; set; }

        /// <summary>
        /// List of all selected roles.
        /// </summary>
        public List<Guid> SelectedRoles { get; set; }

        /// <summary>
        /// Method that apply roles dictionary into <see cref="RoleOptions"/>.
        /// </summary>
        /// <param name="rolesDictionary"></param>
        public void SetRoleOptions(Dictionary<Guid, string> rolesDictionary)
        {
            foreach (var role in rolesDictionary)
            {
                this.RoleOptions.Add(new RoleOption
                {
                    Value = role.Key,
                    Name = role.Value,
                });
            }
        }

        /// <summary>
        /// Method that apply roles dictionary into <see cref="SelectedRoles"/>.
        /// </summary>
        /// <param name="userRolesDictionary"></param>
        public void SetSelectedRoles(Dictionary<Guid, string> userRolesDictionary)
        {
            foreach (var role in userRolesDictionary)
            {
                this.SelectedRoles.Add(role.Key);
            }
        }

        /// <summary>
        /// Helper role option struct.
        /// </summary>
        public struct RoleOption
        {
            /// <summary>
            /// Value property that represent the id of the role.
            /// </summary>
            public Guid Value { get; set; }

            /// <summary>
            /// Name of the role.
            /// </summary>
            public string Name { get; set; }
        }
    }
}
