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
        private readonly List<Type> databaseInitializers = new List<Type>();

        /// <summary>
        /// Initializes a new instance of the <see cref="EmOptions"/> class.
        /// </summary>
        public EmOptions()
        {
            this.Account = new AccountOptions();
            this.Mapping = new MappingOptions();
            this.Assemblies = new List<Assembly>();
            this.AdditionalRoles = new Dictionary<string, string[]>();
            this.ExternalOptions = new Dictionary<Type, object>();
        }

        /// <summary>
        /// General name of the project. Default value is 'Emeraude'.
        /// </summary>
        public string ProjectName { get; set; } = "Emeraude";

        /// <summary>
        /// Activate test mode for the application. Recommended for unit and integration tests.
        /// </summary>
        public bool TestMode { get; set; }

        /// <summary>
        /// Provider of database storage for the application.
        /// </summary>
        public DatabaseContextProvider DatabaseContextProvider { get; set; }

        /// <summary>
        /// Provider of logger storage for the application.
        /// </summary>
        public DatabaseContextProvider LoggerContextProvider { get; set; }

        /// <summary>
        /// Admin dashboard request type.
        /// </summary>
        public Type AdminDashboardRequestType { get; set; }

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
        public Dictionary<string, string[]> AdditionalRoles { get; set; }

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
        public string EmeraudeVersion => this.EmeraudeAssembly?.GetName()?.Version?.ToString();

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
        /// Contains external options dictionary separated by type.
        /// </summary>
        public Dictionary<Type, object> ExternalOptions { get; }

        /// <summary>
        /// Add additional role to the roles of the system. It is prefered to be added before first initialization of the system.
        /// </summary>
        /// <param name="roleName"></param>
        /// <param name="claims"></param>
        public void AddRole(string roleName, string[] claims)
        {
            this.AdditionalRoles[roleName] = claims;
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

        /// <summary>
        /// Add external option into the options instance.
        /// </summary>
        /// <param name="option"></param>
        /// <typeparam name="TOption">Type of the external option.</typeparam>
        public void AddExternalOptions<TOption>(TOption option)
        {
            this.ExternalOptions[typeof(TOption)] = option;
        }

        /// <summary>
        /// Gets instance of applied external option.
        /// </summary>
        /// <typeparam name="TOption">Type of the external option.</typeparam>
        /// <returns></returns>
        public TOption GetExternalOption<TOption>()
        {
            var targetType = typeof(TOption);
            if (this.ExternalOptions.ContainsKey(targetType))
            {
                return (TOption)this.ExternalOptions[targetType];
            }

            return default;
        }
    }
}
