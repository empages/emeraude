using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Common.Interfaces.Persistence.Seed
{
    public interface IDatabaseInitializer
    {
        Task SeedAsync();
    }
}
