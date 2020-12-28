using System.Collections.Generic;

namespace EmDoggo.Application.Requests.Commands.ComplexRequest
{
    public class ComplexRequestRequest
    {
        public string Description { get; set; }

        public IEnumerable<NestedComplexType> NestedCollection { get; set; }
    }
}