using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmDoggo.WebHost.Controllers;

[ApiController]
[Route("/api/dogs")]
public class DogsController : ControllerBase
{
    [HttpGet]
    public async Task<ActionResult> Fetch()
    {
        return this.Ok();
    }
}