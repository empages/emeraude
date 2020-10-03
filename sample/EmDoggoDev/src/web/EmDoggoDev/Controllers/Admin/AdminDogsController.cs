using Definux.Emeraude.Admin.Controllers.Abstractions;
using EmDoggoDev.Application.Models.Admin.Dogs;
using EmDoggoDev.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmDoggoDev.Controllers.Admin
{
    [Route("/admin/dogs/")]
    public class AdminDogsController : AdminEntityController<Dog, DogViewModel>
    {
        public AdminDogsController()
        {
            HasCreate = false;
            HasEdit = false;
        }
    }
}
