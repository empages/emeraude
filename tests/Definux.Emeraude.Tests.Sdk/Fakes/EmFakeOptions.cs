using Definux.Emeraude.Configuration.Options;

namespace Definux.Emeraude.Tests.Sdk.Fakes
{
    public class EmFakeOptions : IEmOptions
    {
        public string FakeValue { get; set; }
        
        public void Validate()
        {
        }
    }
}