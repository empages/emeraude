using System;
using System.Collections.Generic;
using System.Reflection;

namespace Definux.Emeraude.Configuration.Options
{
    /// <summary>
    /// Emeraude framework options class.
    /// </summary>
    public class EmOptions
    {
        private string adminDashboardIndexRedirectRoute = "/admin/analytics";
        private List<Type> databaseInitializers = new List<Type>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmOptions"/> class.
        /// </summary>
        public EmOptions()
        {
            this.Account = new AccountOptions();
            this.Mapping = new MappingOptions();
            this.Assemblies = new List<Assembly>();
            this.AdditonalRoles = new Dictionary<string, string[]>();
        }

        /// <summary>
        /// General name of the project. Default value is 'Emeraude'.
        /// </summary>
        public string ProjectName { get; set; } = "Emeraude";

        /// <summary>
        /// Provider of database storage for the application.
        /// </summary>
        public DatabaseContextProvider DatabaseContextProvider { get; set; }

        /// <summary>
        /// Route used for the administration index page. The string must starts with '/admin/' and cannot be set to '/admin'. The default value is '/admin/analytics'.
        /// </summary>
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

        /// <summary>
        /// AutoMapper configuration options. For more information see <see cref="MappingOptions"/>.
        /// </summary>
        public MappingOptions Mapping { get; set; }

        /// <summary>
        /// Account configuration options. For more information see <see cref="AccountOptions"/>.
        /// </summary>
        public AccountOptions Account { get; set; }

        /// <summary>
        /// List with all assemblies used for registration of execution services and requests.
        /// </summary>
        public List<Assembly> Assemblies { get; set; }

        /// <summary>
        /// Execution assembly of the application.
        /// </summary>
        public Assembly EmeraudeAssembly { get; private set; }

        /// <summary>
        /// Dictionary that contains all additional roles and their claims.
        /// </summary>
        public Dictionary<string, string[]> AdditonalRoles { get; set; }

        /// <summary>
        /// Flag that turn on/off auto execution of migrations for all database contexts.
        /// </summary>
        public bool ExecuteMigrations { get; set; }

        /// <summary>
        /// Flag that turn on/off the maintenance mode of the application. If it is set to 'true' all public client controllers will be available only after admin authentication.
        /// </summary>
        public bool MaintenanceMode { get; set; }

        /// <summary>
        /// Get the current Emeraude Framework version.
        /// </summary>
        public string EmeraudeVersion
        {
            get
            {
                return this.EmeraudeAssembly?.GetName()?.Version?.ToString();
            }
        }

        /// <summary>
        /// Contains the migrations assembly name.
        /// </summary>
        public string MigrationsAssembly { get; set; }

        /// <summary>
        /// Provides the availability to be used custom logger with the base logger definitions.
        /// </summary>
        public bool UseExternalLoggerImplementation { get; set; }

        /// <summary>
        /// Collection of all database initializers.
        /// </summary>
        public Type[] DatabaseInitializers => this.databaseInitializers.ToArray();

        /// <summary>
        /// Add additional role to the roles of the system. It is prefered to be added before first initialization of the system.
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="claims"></param>
        public void AddRole(string roleName, string[] claims)
        {
            this.AdditonalRoles[roleName] = claims;
        }

        /// <summary>
        /// Add assembly for the registration purposes of requests, validators, and handlers.
        /// </summary>
        /// <param name="assemblyName"></param>
        public void AddAssembly(string assemblyName)
        {
            this.Assemblies.Add(Assembly.Load(assemblyName));
        }

        /// <summary>
        /// Add assembly for the registration purposes of requests, validators, and handlers.
        /// </summary>
        /// <param name="assembly"></param>
        public void AddAssembly(Assembly assembly)
        {
            this.Assemblies.Add(assembly);
        }

        /// <summary>
        /// Set the application execution assembly if the value is not set.
        /// </summary>
        /// <param name="assembly"></param>
        public void SetEmeraudeAssembly(Assembly assembly)
        {
            if (this.EmeraudeAssembly == null)
            {
                this.EmeraudeAssembly = assembly;
            }
        }

        /// <summary>
        /// Register a database initializer into the database initializer manager. The order of adding is the order of calling.
        /// </summary>
        /// <typeparam name="TDatabaseInitializer">Interface type of the database initializer.</typeparam>
        public void AddDatabaseInitializer<TDatabaseInitializer>()
        {
            this.databaseInitializers.Add(typeof(TDatabaseInitializer));
        }
    }
}
