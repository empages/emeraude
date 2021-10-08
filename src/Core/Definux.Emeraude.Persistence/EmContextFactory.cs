using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Persistence;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Persistence
{
    /// <inheritdoc />
    public class EmContextFactory<TContext> : IEmContextFactory
        where TContext : DbContext
    {
        private readonly IDbContextFactory<TContext> dbContextFactory;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmContextFactory{TContext}"/> class.
        /// </summary>
        /// <param name="dbContextFactory"></param>
        public EmContextFactory(IDbContextFactory<TContext> dbContextFactory)
        {
            this.dbContextFactory = dbContextFactory;
        }

        /// <inheritdoc />
        public DbContext CreateDbContext()
            => this.dbContextFactory.CreateDbContext();

        /// <inheritdoc />
        public async Task<DbContext> CreateDbContextAsync(CancellationToken cancellationToken = default)
            => await this.dbContextFactory.CreateDbContextAsync(cancellationToken);
    }
}