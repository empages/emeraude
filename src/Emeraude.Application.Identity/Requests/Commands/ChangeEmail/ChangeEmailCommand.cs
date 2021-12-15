using System;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Identity.Services;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.Identity.Requests.Commands.ChangeEmail;

/// <summary>
/// Command that change the email of the specified user.
/// </summary>
public class ChangeEmailCommand : IRequest<SimpleResult>
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ChangeEmailCommand"/> class.
    /// </summary>
    /// <param name="newEmail"></param>
    /// <param name="token"></param>
    public ChangeEmailCommand(string newEmail, string token)
    {
        this.NewEmail = newEmail;
        this.Token = token;
    }

    /// <summary>
    /// Initializes a new instance of the <see cref="ChangeEmailCommand"/> class.
    /// </summary>
    public ChangeEmailCommand()
    {
    }

    /// <summary>
    /// Email of the user.
    /// </summary>
    public string NewEmail { get; set; }

    /// <summary>
    /// Confirmation token of the user.
    /// </summary>
    public string Token { get; set; }

    /// <summary>
    /// Flag that executes the request without the need of token. The default is 'false'.
    /// </summary>
    public bool IgnoreToken { get; set; }

    /// <inheritdoc />
    public class ChangeEmailCommandHandler : IRequestHandler<ChangeEmailCommand, SimpleResult>
    {
        private readonly IUserManager userManager;
        private readonly ILogger<ChangeEmailCommandHandler> logger;
        private readonly ICurrentUserProvider currentUserProvider;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeEmailCommandHandler"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="logger"></param>
        /// <param name="currentUserProvider"></param>
        public ChangeEmailCommandHandler(IUserManager userManager, ILogger<ChangeEmailCommandHandler> logger, ICurrentUserProvider currentUserProvider)
        {
            this.userManager = userManager;
            this.logger = logger;
            this.currentUserProvider = currentUserProvider;
        }

        /// <inheritdoc />
        public async Task<SimpleResult> Handle(ChangeEmailCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var user = await this.currentUserProvider.GetCurrentUserAsync();
                string token = request.Token;
                if (request.IgnoreToken)
                {
                    token = await this.userManager.GenerateChangeEmailTokenAsync(user, request.NewEmail);
                }

                var result = await this.userManager.ChangeEmailAsync(user, request.NewEmail, token);
                return result.Succeeded ? SimpleResult.SuccessfulResult : SimpleResult.UnsuccessfulResult;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Change user email command fails");
                return SimpleResult.UnsuccessfulResult;
            }
        }
    }
}