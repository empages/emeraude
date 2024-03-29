﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

namespace Emeraude.Configuration.Options;

/// <summary>
/// Emeraude Framework main options.
/// </summary>
public class EmMainOptions : IEmOptions
{
    private List<Assembly> assemblies;
    private string domainAssembly;
    private string applicationAssembly;
    private string infrastructureAssembly;
    private string adminAssembly;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmMainOptions"/> class.
    /// </summary>
    public EmMainOptions()
    {
        this.assemblies = new List<Assembly>();
    }

    /// <summary>
    /// General name of the project. Default value is 'Emeraude'.
    /// </summary>
    public string ProjectName { get; set; } = "Emeraude";

    /// <summary>
    /// Base URI of the application.
    /// </summary>
    public string BaseUri { get; set; }

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
    /// Contains the admin assembly name.
    /// </summary>
    public string AdminAssembly
    {
        get => this.adminAssembly;
        set
        {
            this.adminAssembly = value;
            this.AddAssembly(this.adminAssembly);
        }
    }

    /// <summary>
    /// List with all assemblies used for registration of execution services and requests.
    /// </summary>
    public List<Assembly> Assemblies => this.assemblies;

    /// <summary>
    /// Execution assembly of the application.
    /// </summary>
    public Assembly EmeraudeAssembly { get; private set; }

    /// <summary>
    /// Flag that turn on/off auto execution of migrations for all database contexts.
    /// </summary>
    public bool ExecuteMigrations { get; set; }

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
        this.assemblies.Add(Assembly.Load(assemblyName));
    }

    /// <summary>
    /// Add assembly for the registration purposes of requests, validators, and handlers.
    /// </summary>
    /// <param name="assembly"></param>
    public void AddAssembly(Assembly assembly)
    {
        this.assemblies.Add(assembly);
        this.assemblies = this.assemblies.DistinctBy(x => x.FullName).ToList();
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