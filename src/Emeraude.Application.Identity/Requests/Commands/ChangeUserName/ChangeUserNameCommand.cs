using System;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Essentials.Models;
using Emeraude.Infrastructure.Identity.Services;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.Identity.Requests.Commands.ChangeUserName;

/// <summary>
/// Command that change the user's name.
/// </summary>
public class ChangeUserNameCommand : IRequest<SimpleResult>
{
    /// <summary>
    /// Id of the user.
    /// </summary>
    public Guid? UserId { get; set; }

    /// <summary>
    /// New name of the user.
    /// </summary>
    public string NewName { get; set; }

    /// <inheritdoc/>
    public class ChangeUserNameCommandHandler : IRequestHandler<ChangeUserNameCommand, SimpleResult>
    {
        private readonly IUserManager userManager;
        private readonly ILogger<ChangeUserNameCommandHandler> logger;

        /// <summary>
        /// Initializes a new instance of the <see cref="ChangeUserNameCommandHandler"/> class.
        /// </summary>
        /// <param name="userManager"></param>
        /// <param name="logger"></param>
        public ChangeUserNameCommandHandler(IUserManager userManager, ILogger<ChangeUserNameCommandHandler> logger)
        {
            this.userManager = userManager;
            this.logger = logger;
        }

        /// <inheritdoc/>
        public async Task<SimpleResult> Handle(ChangeUserNameCommand request, CancellationToken cancellationToken)
        {
            try
            {
                if (request.UserId.HasValue)
                {
                    var user = await this.userManager.FindUserByIdAsync(request.UserId.Value);
                    await this.userManager.ChangeUserNameAsync(user, request.NewName);
                    return SimpleResult.SuccessfulResult;
                }

                return SimpleResult.UnsuccessfulResult;
            }
            catch (Exception ex)
            {
                this.logger.LogError(ex, "Change user name command fails");
                return SimpleResult.UnsuccessfulResult;
            }
        }
    }
}