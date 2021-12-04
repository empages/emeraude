using System;
using System.Collections.Generic;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.Extensions.Logging;

namespace Emeraude.Infrastructure.FileStorage.Services;

/// <inheritdoc />
public class TemporaryFilesService : ITemporaryFilesService
{
    private const string ContainerKey = "_TemporaryFilesContainer";

    private readonly IMemoryCache memoryCache;
    private readonly ILogger<TemporaryFilesService> logger;

    /// <summary>
    /// Initializes a new instance of the <see cref="TemporaryFilesService"/> class.
    /// </summary>
    /// <param name="memoryCache"></param>
    /// <param name="logger"></param>
    public TemporaryFilesService(IMemoryCache memoryCache, ILogger<TemporaryFilesService> logger)
    {
        this.memoryCache = memoryCache;
        this.logger = logger;

        this.InitializeContainer();
    }

    /// <inheritdoc />
    public string GetFile(Guid fileId)
    {
        var container = this.GetContainer();
        return container.ContainsKey(fileId) ? container[fileId] : null;
    }

    /// <inheritdoc />
    public Guid SaveFile(string filePath)
    {
        var container = this.GetContainer();
        var fileId = Guid.NewGuid();
        container[fileId] = filePath;
        this.SaveContainer(container);

        return fileId;
    }

    /// <inheritdoc/>
    public void DeleteFile(Guid fileId)
    {
        var container = this.GetContainer();
        if (container.ContainsKey(fileId))
        {
            container.Remove(fileId);
            this.SaveContainer(container);
        }
    }

    private void InitializeContainer()
    {
        var container = new Dictionary<Guid, string>();
        this.SaveContainer(container);
    }

    private IDictionary<Guid, string> GetContainer()
    {
        this.memoryCache.TryGetValue(ContainerKey, out var container);
        if (container != null)
        {
            return (IDictionary<Guid, string>)container;
        }

        return new Dictionary<Guid, string>();
    }

    private void SaveContainer(IDictionary<Guid, string> container)
    {
        var containerCacheOptions = new MemoryCacheEntryOptions()
            .SetSlidingExpiration(TimeSpan.FromDays(1));
        this.memoryCache.Set(ContainerKey, container, containerCacheOptions);
    }
}