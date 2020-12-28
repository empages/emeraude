using AutoMapper;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using EmDoggo.Application.Interfaces;

namespace EmDoggo.Application.Requests.Commands.ComplexRequest
{
    public class ComplexRequestCommand : ComplexRequestRequest, IRequest<ComplexRequestResult>
    {
        public class ComplexRequestCommandHandler : IRequestHandler<ComplexRequestCommand, ComplexRequestResult>
        {
            private readonly IEntityContext context;
            private readonly IMapper mapper;

            public ComplexRequestCommandHandler(IEntityContext context, IMapper mapper)
            {
                this.context = context;
                this.mapper = mapper;
            }

            public async Task<ComplexRequestResult> Handle(ComplexRequestCommand request, CancellationToken cancellationToken)
            {
                return new ComplexRequestResult();
            }
        }
    }
}