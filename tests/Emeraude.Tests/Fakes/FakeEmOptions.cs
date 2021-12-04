using Emeraude.Configuration.Options;

namespace Emeraude.Tests.Fakes;

public class FakeEmOptions : IEmOptions
{
    public string SomeString { get; set; }
        
    public void Validate()
    {
    }
}