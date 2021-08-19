using Definux.Emeraude.Application.Models;
using Definux.Utilities.Objects;

namespace EmDoggo.Application.Requests.Commands.ComplexRequest
{
    public class ComplexRequestResult
    {
        public bool Success { get; set; }

        public PaginatedList<SomeResultItem> PaginatedCollection { get; set; }

        public DateModel Date { get; set; }
        
        public DateModel? DateNullable { get; set; }
    }
}