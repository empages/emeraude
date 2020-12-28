using Definux.Utilities.Objects;

namespace EmDoggo.Application.Requests.Commands.ComplexRequest
{
    public class ComplexRequestResult
    {
        public bool Success { get; set; }

        public PaginatedList<SomeResultItem> PaginatedCollection { get; set; }
    }
}