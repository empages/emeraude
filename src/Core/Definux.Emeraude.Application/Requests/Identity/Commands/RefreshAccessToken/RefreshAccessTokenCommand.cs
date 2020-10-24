using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.RefreshAccessToken
{
    /// <summary>
    /// Command for refresh access token of specified user.
    /// </summary>
    public class RefreshAccessTokenCommand : RefreshAccessTokenRequest, IRequest<BearerAuthenticationResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshAccessTokenCommand"/> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="request"></param>
        public RefreshAccessTokenCommand(Guid? userId, RefreshAccessTokenRequest request)
        {
            this.UserId = userId;
            this.RefreshToken = request.RefreshToken;
        }

        /// <summary>
        /// Target user id.
        /// </summary>
        public Guid? UserId { get; set; }

        /// <inheritdoc/>
        public class RefreshAccessTokenCommandHandler : IRequestHandler<RefreshAccessTokenCommand, BearerAuthenticationResult>
        {
            private readonly IUserTokensService userTokensService;

            /// <summary>
            /// Initializes a new instance of the <see cref="RefreshAccessTokenCommandHandler"/> class.
            /// </summary>
            /// <param name="userTokensService"></param>
            public RefreshAccessTokenCommandHandler(IUserTokensService userTokensService)
            {
                this.userTokensService = userTokensService;
            }

            /// <inheritdoc/>
            public async Task<BearerAuthenticationResult> Handle(RefreshAccessTokenCommand request, CancellationToken cancellationToken)
            {
                return await this.userTokensService.RefreshJwtTokenAsync(request.UserId, request.RefreshToken);
            }
        }
    }
}
