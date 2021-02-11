using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Requests;
using MediatR;

namespace EmDoggo.Application.Requests.Queries.AdminDashboard
{
    public class AdminDashboardQuery : IDashboardRequest<AdminDashboardViewModel>
    {
        public class AdminDashboardQueryHandler : IRequestHandler<AdminDashboardQuery, AdminDashboardViewModel>
        {
            public async Task<AdminDashboardViewModel> Handle(AdminDashboardQuery request, CancellationToken cancellationToken)
            {
                return new AdminDashboardViewModel
                {
                    Message = "My custom dashboard message"
                };
            }
        }
    }
}