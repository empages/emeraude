using System.Collections.Generic;
using System.Threading.Tasks;
using Emeraude.Application.Admin.EmPages.Schema;

namespace Emeraude.Application.Admin.EmPages.Services
{
    /// <summary>
    /// Schema factory for initializing EmPages schemas and their corresponding properties.
    /// </summary>
    public interface IEmPageSchemaFactory
    {
        /// <summary>
        /// Creates a new instance for each registered schema of the solution assemblies.
        /// </summary>
        /// <returns></returns>
        Task<IEnumerable<EmPageSchemaDescription>> CreateSchemasInstancesAsync();
    }
}