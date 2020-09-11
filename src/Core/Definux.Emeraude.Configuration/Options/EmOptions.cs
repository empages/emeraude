using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Definux.Emeraude.Configuration.Options
{
    public class EmOptions
    {
        private string adminDashboardIndexRedirectRoute = "/admin/analytics";

        public EmOptions()
        {
            Account = new AccountOptions();
            Mapping = new MappingOptions();
            Assemblies = new List<Assembly>();
            AdditonalRoles = new Dictionary<string, string[]>();
        }

        public string ProjectName { get; set; } = "Emeraude";

        public string AdminDashboardIndexRedirectRoute
        {
            get
            {
                return this.adminDashboardIndexRedirectRoute;
            }
            set
            {
                if (string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Admin dashboard redirection route cannot be set to empty");
                }

                if (!value.StartsWith("/admin/", StringComparison.OrdinalIgnoreCase))
                {
                    throw new ArgumentException("Admin dashboard redirection route must starts with '/admin/'");
                }

                string tempUrl = "https://emeraude.dev";
                Uri url = new Uri($"{tempUrl}{value}");
                string path = url.GetLeftPart(UriPartial.Path);
                if (path.EndsWith("/"))
                {
                    path = path.Substring(0, path.Length - 1);
                }

                path = path.Replace(tempUrl, string.Empty);

                if (path == "/admin")
                {
                    throw new ArgumentException("Admin dashboard redirection route cannot be set to '/admin'");
                }

                this.adminDashboardIndexRedirectRoute = value;
            }
        }

        public MappingOptions Mapping { get; set; }

        public AccountOptions Account { get; set; }

        public bool UseDefaultIdentity { get; set; } = true;

        public List<Assembly> Assemblies { get; set; }

        public Assembly EmeraudeAssembly { get; private set; }

        public Dictionary<string, string[]> AdditonalRoles { get; set; }

        public bool ExecuteMigrations { get; set; }

        public void AddRole(string roleName, string[] claims)
        {
            AdditonalRoles[roleName] = claims;
        }

        public string EmeraudeVersion
        {
            get
            {
                return EmeraudeAssembly?.GetName()?.Version?.ToString();
            }
        }

        /// <summary>
        /// Add assembly for the registration purposes of requests, validators, and handlers.
        /// </summary>
        /// <param name="assemblyName"></param>
        public void AddAssembly(string assemblyName)
        {
            Assemblies.Add(Assembly.Load(assemblyName));
        }

        /// <summary>
        /// Add assembly for the registration purposes of requests, validators, and handlers.
        /// </summary>
        /// <param name="assembly"></param>
        public void AddAssembly(Assembly assembly)
        {
            Assemblies.Add(assembly);
        }

        public void SetEmeraudeAssembly(Assembly assembly)
        {
            if (EmeraudeAssembly == null)
            {
                EmeraudeAssembly = assembly;
            }
        }
    }
}
