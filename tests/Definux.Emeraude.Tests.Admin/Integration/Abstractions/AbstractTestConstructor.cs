using Definux.Emeraude.Tests.Admin.Integration.Setup.Web;

namespace Definux.Emeraude.Tests.Admin.Integration.Abstractions
{
    public abstract class AbstractTestConstructor
    {
        private readonly TestServerFixture testServerFixture = new TestServerFixture();

        public TService GetService<TService>() where TService : class
        {
            return this.testServerFixture.TestServer?.Host?.Services?.GetService(typeof(TService)) as TService;
        }
    }
}