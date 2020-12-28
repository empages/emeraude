using System;
using System.Collections.Generic;

namespace EmDoggo.Application.Requests.Commands.ComplexRequest
{
    public class NestedComplexType
    {
        public Guid Id { get; set; }

        public IEnumerable<DeepNestedComplexType> DeepCollection { get; set; }
    }
}