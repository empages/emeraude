using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Domain;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Tests.Admin.Integration.Setup.Application.Interfaces
{
    public interface ITestEntityContext : IEmContext
    {
        DbSet<SimpleEntity> SimpleEntities { get; set; }
    }
}