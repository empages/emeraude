using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Emeraude.Application.Common.Results.Identity;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken
{
    public class RefreshAccessTokenCommand : RefreshAccessTokenRequest, IRequest<BearerAuthenticationResult>
    {
        public RefreshAccessTokenCommand(Guid? userId, RefreshAccessTokenRequest request)
        {
            UserId = userId;
            RefreshToken = request.RefreshToken;
        }
        public Guid? UserId { get; set; }

        public class RefreshAccessTokenCommandHandler : IRequestHandler<RefreshAccessTokenCommand, BearerAuthenticationResult>
        {
            private readonly IUserTokensService userTokensService;

            public RefreshAccessTokenCommandHandler(IUserTokensService userTokensService)
            {
                this.userTokensService = userTokensService;
            }

            public async Task<BearerAuthenticationResult> Handle(RefreshAccessTokenCommand request, CancellationToken cancellationToken)
            {
                return await this.userTokensService.RefreshJwtTokenAsync(request.UserId, request.RefreshToken);
            }
        }
    }

}
