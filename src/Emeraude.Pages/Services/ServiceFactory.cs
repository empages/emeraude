using System;
using Microsoft.Extensions.DependencyInjection;

namespace Emeraude.Pages.Services;

/// <inheritdoc />
internal class ServiceFactory : IEmServiceFactory
{
    private readonly IServiceProvider serviceProvider;

    /// <summary>
    /// Initializes a new instance of the <see cref="ServiceFactory"/> class.
    /// </summary>
    /// <param name="serviceProvider"></param>
    public ServiceFactory(IServiceProvider serviceProvider)
    {
        this.serviceProvider = serviceProvider;
    }

    /// <inheritdoc/>
    public IEmPage CreatePage(Type type) =>
        this.CreateInstanceOf<IEmPage>(type);

    /// <inheritdoc/>
    public IEmPageCommand CreateCommand(Type type) =>
        this.CreateInstanceOf<IEmPageCommand>(type);

    private TType CreateInstanceOf<TType>(Type type)
    {
        using var scope = this.serviceProvider.CreateScope();
        return (TType)scope.ServiceProvider.GetRequiredService(type);
    }
}