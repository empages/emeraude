using System;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Application.Persistence;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Application.Requests.Identity.Commands.ChangeEmail
{
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
        /// Email of the user.
        /// </summary>
        public string NewEmail { get; set; }

        /// <summary>
        /// Confirmation token of the user.
        /// </summary>
        public string Token { get; set; }

        /// <inheritdoc />
        public class ChangeEmailCommandHandler : IRequestHandler<ChangeEmailCommand, SimpleResult>
        {
            private readonly IUserManager userManager;
            private readonly IEmLogger logger;
            private readonly ICurrentUserProvider currentUserProvider;

            /// <summary>
            /// Initializes a new instance of the <see cref="ChangeEmailCommandHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            /// <param name="logger"></param>
            /// <param name="currentUserProvider"></param>
            public ChangeEmailCommandHandler(IUserManager userManager, IEmLogger logger, ICurrentUserProvider currentUserProvider)
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
                    var result = await this.userManager.ChangeEmailAsync(user, request.NewEmail, request.Token);
                    return result.Succeeded ? SimpleResult.SuccessfulResult : SimpleResult.UnsuccessfulResult;
                }
                catch (Exception ex)
                {
                    await this.logger.LogErrorAsync(ex);
                    return SimpleResult.UnsuccessfulResult;
                }
            }
        }
    }
}