using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Logging.Debug;

namespace Emeraude.Tests.Base
{
    public class TestsDatabaseContextBuilder<TContext>
        where TContext : DbContext
    {
        private readonly LoggerFactory loggerFactory = new (new[] { new DebugLoggerProvider() });
        private readonly DbContextOptionsBuilder<TContext> contextOptionsBuilder = new ();

        public TestsDatabaseContextBuilder()
        {
            this.contextOptionsBuilder
                .UseInMemoryDatabase(Guid.NewGuid().ToString());
        }

        public TContext Build(DbContextOptions<TContext> options = null)
        {
            this.contextOptionsBuilder
                .EnableSensitiveDataLogging(true)
                .UseLoggerFactory(this.loggerFactory);

            var context = Activator.CreateInstance(typeof(TContext), options ?? this.contextOptionsBuilder.Options) as TContext;
            return context;
        }
    }
}