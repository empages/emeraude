using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.ViewModels.Users
{
    public class RolesViewModel
    {
        public RolesViewModel()
        {
            RoleOptions = new List<RoleOption>();
            SelectedRoles = new List<Guid>();
        }

        [BindNever]
        public List<RoleOption> RoleOptions { get; set; }

        public List<Guid> SelectedRoles { get; set; }

        public void SetRoleOptions(Dictionary<Guid, string> rolesDictionary)
        {
            foreach (var role in rolesDictionary)
            {
                RoleOptions.Add(new RoleOption
                {
                    Value = role.Key,
                    Name = role.Value
                });
            }
        }

        public void SetSelectedRoles(Dictionary<Guid, string> userRolesDictionary)
        {
            foreach (var role in userRolesDictionary)
            {
                SelectedRoles.Add(role.Key);
            }
        }

        public struct RoleOption
        {
            public Guid Value { get; set; }

            public string Name { get; set; }
        }
    }
}
