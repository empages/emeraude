using Definux.Emeraude.Admin.Controllers.Abstractions;
using EmDoggo.Application.Models.Admin.Dogs;
using EmDoggo.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace EmDoggo.Controllers.Admin
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
