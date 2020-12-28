using EmDoggo.Domain.Common;

namespace EmDoggo.Application.Requests.Commands.ComplexRequest
{
    public class DeepNestedComplexType
    {
        public string Name { get; set; }
        
        public ComplexEnum ComplexEnum { get; set; }
    }
}