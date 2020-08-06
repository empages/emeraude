using Definux.Emeraude.Application.Common.Interfaces.Identity.Services;
using Definux.Utilities.Objects;
using MediatR;
using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Admin.Requests.AssignRolesToUser
{
    public class AssignRolesToUserCommand : IRequest<SimpleResult>
    {
        public AssignRolesToUserCommand(Guid userId, List<Guid> rolesIds)
        {
            UserId = userId;
            RolesIds = rolesIds;
        }

        public Guid UserId { get; set; }

        public List<Guid> RolesIds { get; set; }

        public class AssignRolesToUserCommandHandler : IRequestHandler<AssignRolesToUserCommand, SimpleResult>
        {
            private readonly IRoleManager roleManager;
            private readonly IUserManager userManager;

            public AssignRolesToUserCommandHandler(IRoleManager roleManager, IUserManager userManager)
            {
                this.roleManager = roleManager;
                this.userManager = userManager;
            }

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
