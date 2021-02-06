using System;
using System.Reflection;
using Definux.Emeraude.Persistence;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Application.Interfaces;
using Definux.Emeraude.Tests.Admin.Integration.Setup.Domain;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Tests.Admin.Integration.Setup.Infrastructure.Persistence
{
    public class TestEntityContext : EmContext<TestEntityContext>, ITestEntityContext
    {
        public TestEntityContext(
            DbContextOptions<TestEntityContext> options,
            IHttpContextAccessor httpAccessor,
            IServiceProvider serviceProvider) 
            : base(options, httpAccessor, serviceProvider)
        {
        }

        public DbSet<SimpleEntity> SimpleEntities { get; set; }
        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(builder);
        }
    }
}