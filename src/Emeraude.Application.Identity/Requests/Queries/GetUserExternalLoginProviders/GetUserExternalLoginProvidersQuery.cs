using System;
using System.Threading;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Identity.Services;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Emeraude.Application.Identity.Requests.Queries.GetUserExternalLoginProviders
{
    /// <summary>
    /// Query that returns the specified user external login providers.
    /// </summary>
    public class GetUserExternalLoginProvidersQuery : IRequest<GetUserExternalLoginProvidersResult>
    {
        /// <summary>
        /// Id of the user.
        /// </summary>
        public Guid UserId { get; set; }

        /// <inheritdoc/>
        public class GetUserExternalLoginProvidersQueryHandler : IRequestHandler<GetUserExternalLoginProvidersQuery, GetUserExternalLoginProvidersResult>
        {
            private readonly IUserManager userManager;
            private readonly ILogger<GetUserExternalLoginProvidersQueryHandler> logger;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetUserExternalLoginProvidersQueryHandler"/> class.
            /// </summary>
            /// <param name="userManager"></param>
            /// <param name="logger"></param>
            public GetUserExternalLoginProvidersQueryHandler(
                IUserManager userManager,
                ILogger<GetUserExternalLoginProvidersQueryHandler> logger)
            {
                this.userManager = userManager;
                this.logger = logger;
            }

            /// <inheritdoc/>
            public async Task<GetUserExternalLoginProvidersResult> Handle(GetUserExternalLoginProvidersQuery request, CancellationToken cancellationToken)
            {
                var result = new GetUserExternalLoginProvidersResult();
                try
                {
                    var user = await this.userManager.FindUserByIdAsync(request.UserId);

                    if (user != null)
                    {
                        var currentUserExternalLoginProviders =
                            await this.userManager.GetLoginsAsync(user);

                        foreach (var loginProvider in currentUserExternalLoginProviders)
                        {
                            result.Providers.Add(new UserExternalLoginProvider
                            {
                                Provider = loginProvider.LoginProvider,
                                ProviderDisplayName = loginProvider.ProviderDisplayName,
                            });
                        }
                    }

                    return result;
                }
                catch (Exception ex)
                {
                    this.logger.LogError(ex, "Get user external login providers query fails");
                    return result;
                }
            }
        }
    }
}