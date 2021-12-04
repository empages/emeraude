using System;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.Models;
using Emeraude.Infrastructure.Identity.Services;
using MediatR;

namespace Emeraude.Application.Identity.Requests.Commands.RefreshAccessToken;

/// <summary>
/// Command for refresh access token of specified user.
/// </summary>
public class RefreshAccessTokenCommand : IRequest<BearerAuthenticationResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="RefreshAccessTokenCommand"/> class.
    /// </summary>
    /// <param name="userId"></param>
    /// <param name="refreshToken"></param>
    public RefreshAccessTokenCommand(Guid? userId, string refreshToken)
    {
        this.UserId = userId;
        this.RefreshToken = refreshToken;
    }

    /// <summary>
    /// Refresh token.
    /// </summary>
    public string RefreshToken { get; set; }

    /// <summary>
    /// Target user id.
    /// </summary>
    public Guid? UserId { get; set; }

    /// <inheritdoc/>
    public class RefreshAccessTokenCommandHandler : IRequestHandler<RefreshAccessTokenCommand, BearerAuthenticationResult>
    {
        private readonly IUserTokensService userTokensService;
        private readonly ICurrentUserProvider currentUserProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="RefreshAccessTokenCommandHandler"/> class.
        /// </summary>
        /// <param name="userTokensService"></param>
        /// <param name="currentUserProvider"></param>
        public RefreshAccessTokenCommandHandler(IUserTokensService userTokensService, ICurrentUserProvider currentUserProvider)
        {
            this.userTokensService = userTokensService;
            this.currentUserProvider = currentUserProvider;
        }

        /// <inheritdoc/>
        public async Task<BearerAuthenticationResult> Handle(RefreshAccessTokenCommand request, CancellationToken cancellationToken)
        {
            return await this.userTokensService.RefreshJwtTokenAsync(request.UserId, request.RefreshToken, this.currentUserProvider.CurrentUserId.HasValue);
        }
    }
}