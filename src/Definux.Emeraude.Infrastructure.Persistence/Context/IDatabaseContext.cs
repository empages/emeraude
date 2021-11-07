using System.Threading;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Infrastructure.Persistence.Context
{
    /// <summary>
    /// Database context interface of Emeraude application that contains main functions of <see cref="DbContext"/>.
    /// </summary>
    public interface IDatabaseContext
    {
        /// <summary>
        /// Creates a Microsoft.EntityFrameworkCore.DbSet`1 that can be used to query and save instances of TEntity.
        /// </summary>
        /// <typeparam name="TEntity">The type of entity for which a set should be returned.</typeparam>
        /// <returns></returns>
        DbSet<TEntity> Set<TEntity>()
            where TEntity : class;

        /// <summary>
        /// <inheritdoc cref="DbContext.SaveChanges()" />
        /// </summary>
        /// <returns></returns>
        int SaveChanges();

        /// <inheritdoc cref="DbContext.SaveChanges()"/>
        int SaveChanges(bool acceptAllChangesOnSuccess);

        /// <inheritdoc cref="DbContext.SaveChangesAsync(bool,System.Threading.CancellationToken)"/>
        Task<int> SaveChangesAsync(bool acceptAllChangesOnSuccess, CancellationToken cancellationToken = default(CancellationToken));

        /// <inheritdoc cref="DbContext.SaveChangesAsync(System.Threading.CancellationToken)"/>
        Task<int> SaveChangesAsync(CancellationToken cancellationToken = default(CancellationToken));
    }
}
