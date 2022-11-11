using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace EmPages.Pages.Services;

/// <inheritdoc cref="IEmPageStore" />
internal class EmPageStore : IEmPageStore, IDisposable
{
    private readonly IEmPagesOptions options;
    private readonly HashSet<EmPageDescriptor> pageDescriptors;
    private readonly ReaderWriterLockSlim cacheLock;
    private bool initialized = false;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageStore"/> class.
    /// </summary>
    /// <param name="options"></param>
    public EmPageStore(IEmPagesOptions options)
    {
        this.options = options;
        this.pageDescriptors = new HashSet<EmPageDescriptor>();
        this.cacheLock = new ReaderWriterLockSlim();
    }

    /// <inheritdoc/>
    public IReadOnlyCollection<EmPageDescriptor> PageDescriptors => this.pageDescriptors;

    /// <inheritdoc/>
    public async Task InitializeAsync()
    {
        this.cacheLock.EnterWriteLock();
        try
        {
            if (this.initialized)
            {
                return;
            }

            var pagesTypes = EmReflectionHelpers.GetPagesTypesFromAssemblies(this.options.PagesAssemblies);
            foreach (var pagesType in pagesTypes)
            {
                this.pageDescriptors.Add(new EmPageDescriptor(pagesType));
            }

            this.initialized = true;
        }
        finally
        {
            this.cacheLock.ExitWriteLock();
        }
    }

    /// <inheritdoc/>
    public void Dispose()
    {
        this.cacheLock?.Dispose();
    }
}