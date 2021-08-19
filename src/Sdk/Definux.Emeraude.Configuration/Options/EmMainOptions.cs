using System;
using System.Collections.Generic;
using System.Reflection;

namespace Definux.Emeraude.Configuration.Options
{
    /// <summary>
    /// Emeraude Framework main options.
    /// </summary>
    public class EmMainOptions : IEmOptions
    {
        private string domainAssembly;
        private string applicationAssembly;
        private string infrastructureAssembly;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmMainOptions"/> class.
        /// </summary>
        public EmMainOptions()
        {
            this.Assemblies = new List<Assembly>();
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
        /// Contains the domain assembly name.
        /// </summary>
        public string DomainAssembly
        {
            get => this.domainAssembly;
            set
            {
                this.domainAssembly = value;
                this.AddAssembly(this.domainAssembly);
            }
        }

        /// <summary>
        /// Contains the infrastructure assembly name.
        /// </summary>
        public string InfrastructureAssembly
        {
            get => this.infrastructureAssembly;
            set
            {
                this.infrastructureAssembly = value;
                this.AddAssembly(this.infrastructureAssembly);
            }
        }

        /// <summary>
        /// Contains the application assembly name.
        /// </summary>
        public string ApplicationAssembly
        {
            get => this.applicationAssembly;
            set
            {
                this.applicationAssembly = value;
                this.AddAssembly(this.applicationAssembly);
            }
        }

        /// <summary>
        /// List with all assemblies used for registration of execution services and requests.
        /// </summary>
        public List<Assembly> Assemblies { get; set; }

        /// <summary>
        /// Execution assembly of the application.
        /// </summary>
        public Assembly EmeraudeAssembly { get; private set; }

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
                this.AddAssembly(assembly);
            }
        }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public void Validate()
        {
        }
    }
}
