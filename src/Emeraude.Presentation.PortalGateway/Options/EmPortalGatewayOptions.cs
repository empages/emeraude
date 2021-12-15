using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using Emeraude.Configuration.Exceptions;
using Emeraude.Configuration.Options;
using Emeraude.Presentation.PortalGateway.Strategies;

namespace Emeraude.Presentation.PortalGateway.Options;

/// <summary>
/// Options for Emeraude portal.
/// </summary>
public class EmPortalGatewayOptions : IEmOptions
{
    private readonly IDictionary<Type, Type> identityActionsStrategies;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPortalGatewayOptions"/> class.
    /// </summary>
    public EmPortalGatewayOptions()
    {
        this.PortalUrls = new List<string>
        {
            EmPortalConstants.EmeraudePortalUrl,
        };

        this.identityActionsStrategies = new Dictionary<Type, Type>();
        this.AddIdentityActionsStrategy<IAuthenticationActionsStrategy, DefaultAuthenticationActionsStrategy>();
        this.AddIdentityActionsStrategy<IManageActionsStrategy, DefaultManageActionsStrategy>();
    }

    /// <summary>
    /// List of all portal URLs that consume data through the gateway.
    /// </summary>
    public IList<string> PortalUrls { get; }

    /// <summary>
    /// Identification of the gateway. Make sure that value is complex enough.
    /// </summary>
    public string GatewayId { get; set; }

    /// <summary>
    /// A pair with the identity strategy services and their implementations.
    /// </summary>
    public IReadOnlyDictionary<Type, Type> IdentityActionsStrategies => new ReadOnlyDictionary<Type, Type>(this.identityActionsStrategies);

    /// <summary>
    /// Registers a custom identity actions strategy.
    /// Consider the fact when you add a custom strategy the default one will be overriden.
    /// </summary>
    /// <typeparam name="TStrategy">Contract type of the strategy action.</typeparam>
    /// <typeparam name="TStrategyImplementation">Implementation type of the strategy action.</typeparam>
    /// <exception cref="EmInvalidConfigurationException"></exception>
    public void AddIdentityActionsStrategy<TStrategy, TStrategyImplementation>()
        where TStrategy : IIdentityActionStrategy
        where TStrategyImplementation : class, TStrategy
    {
        if (typeof(TStrategy) == typeof(IIdentityActionStrategy))
        {
            throw new EmInvalidConfigurationException("You cannot register directly strategy of type IIdentityActionStrategy");
        }

        this.identityActionsStrategies[typeof(TStrategy)] = typeof(TStrategyImplementation);
    }

    /// <inheritdoc/>
    public void Validate()
    {
    }
}