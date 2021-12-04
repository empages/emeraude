using System;
using System.Collections.Generic;
using Emeraude.Configuration.Exceptions;
using Emeraude.Configuration.Options;

namespace Emeraude;

/// <summary>
/// Framework implementation of <see cref="IEmOptionsProvider"/>.
/// </summary>
public class EmOptionsProvider : IEmOptionsProvider
{
    private readonly Dictionary<Type, IEmOptions> optionsFactory;
    private readonly Dictionary<string, object> optionsByAddress;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmOptionsProvider"/> class.
    /// </summary>
    /// <param name="setup"></param>
    public EmOptionsProvider(EmOptionsSetup setup)
    {
        this.optionsFactory = new Dictionary<Type, IEmOptions>();
        this.optionsByAddress = new Dictionary<string, object>();

        this.LoadOptions(setup);
    }

    /// <summary>
    /// <inheritdoc />
    /// </summary>
    /// <typeparam name="TOptions">Type of requested options.</typeparam>
    /// <returns></returns>
    /// <exception cref="EmOptionsNotFoundException">Error in case of non registered options in the options factory.</exception>
    public TOptions GetOptions<TOptions>()
        where TOptions : class, IEmOptions
    {
        var requestedType = typeof(TOptions);
        if (!this.optionsFactory.ContainsKey(requestedType))
        {
            throw new EmOptionsNotFoundException($"Requested options of type '{requestedType.FullName}' have not been found.");
        }

        return (TOptions)this.optionsFactory[requestedType];
    }

    /// <inheritdoc />
    public TValue GetOptionValue<TValue>(string optionAddress)
    {
        if (!this.optionsByAddress.ContainsKey(optionAddress))
        {
            throw new EmOptionsNotFoundException($"Requested option value for the address '{optionAddress}' has not been found.");
        }

        return (TValue)this.optionsByAddress[optionAddress];
    }

    private void LoadOptions(EmOptionsSetup setup)
    {
        var setupProperties = typeof(EmOptionsSetup).GetProperties();
        foreach (var setupProperty in setupProperties)
        {
            var optionsValue = setupProperty.GetValue(setup) as IEmOptions;
            if (optionsValue == null)
            {
                throw new EmMissingConfigurationException($"'{setupProperty.Name}' is missing. Please check your application startup setup.");
            }

            optionsValue.Validate();
            this.optionsFactory[setupProperty.PropertyType] = optionsValue;
            var propertyProperties = setupProperty.PropertyType.GetProperties();
            foreach (var property in propertyProperties)
            {
                this.optionsByAddress[$"{setupProperty.Name}:{property.Name}"] = property.GetValue(optionsValue);
            }
        }
    }
}