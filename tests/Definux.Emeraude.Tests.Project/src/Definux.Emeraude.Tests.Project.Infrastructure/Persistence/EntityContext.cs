using Emeraude.Infrastructure.Persistence;
using Emeraude.Tests.Project.Application.Interfaces.Persistence;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using System;
using System.Reflection;
using Emeraude.Infrastructure.Persistence.Context;

namespace Definux.Emeraude.Tests.Project.Infrastructure.Persistence
{
    public class EntityContext : EmContext<EntityContext>, IEntityContext
    {
        public EntityContext(
            DbContextOptions<EntityContext> options,
            IHttpContextAccessor httpAccessor,
            IServiceProvider serviceProvider)
                : base(options, httpAccessor, serviceProvider)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}
