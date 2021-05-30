using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Identity;
using Definux.Utilities.Objects;
using MediatR;

namespace Definux.Emeraude.Admin.Requests.AssignRolesToUser
{
    /// <summary>
    /// Command for assigning roles to a selected user.
    /// </summary>
    public class AssignRolesToUserCommand : IRequest<SimpleResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="AssignRolesToUserCommand"/> class.
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="rolesIds"></param>
        public AssignRolesToUserCommand(Guid userId, List<Guid> rolesIds)
        {
            this.UserId = userId;
            this.RolesIds = rolesIds;
        }

        /// <summary>
        /// Target user id.
        /// </summary>
        public Guid UserId { get; set; }

        /// <summary>
        /// Roles for assignment.
        /// </summary>
        public List<Guid> RolesIds { get; set; }

        /// <inheritdoc/>
        public class AssignRolesToUserCommandHandler : IRequestHandler<AssignRolesToUserCommand, SimpleResult>
        {
            private readonly IRoleManager roleManager;
            private readonly IUserManager userManager;

            /// <summary>
            /// Initializes a new instance of the <see cref="AssignRolesToUserCommandHandler"/> class.
            /// </summary>
            /// <param name="roleManager"></param>
            /// <param name="userManager"></param>
            public AssignRolesToUserCommandHandler(IRoleManager roleManager, IUserManager userManager)
            {
                this.roleManager = roleManager;
                this.userManager = userManager;
            }

            /// <inheritdoc/>
            public async Task<SimpleResult> Handle(AssignRolesToUserCommand request, CancellationToken cancellationToken)
            {
                bool success = false;
                var user = await this.userManager.FindUserByIdAsync(request.UserId);
                if (user != null && request.RolesIds != null)
                {
                    var unassignedRolesSucceeded = await this.roleManager.UnassignAllRolesFromUserAsync(user);
                    if (unassignedRolesSucceeded)
                    {
                        success = await this.roleManager.AssignRolesToUserAsync(user, request.RolesIds);
                    }
                }

                return new SimpleResult(success);
            }
        }
    }
}
