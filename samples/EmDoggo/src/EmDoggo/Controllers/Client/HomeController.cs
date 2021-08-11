using System.Threading.Tasks;
using Definux.Emeraude.Locales.Attributes;
using Microsoft.AspNetCore.Mvc;

namespace EmDoggo.Controllers.Client
{
    [Route("/")]
    [LanguageRoute("/")]
    public class HomeController : Controller
    {
        public async Task<IActionResult> Index()
        {
            return this.View();
        }
    }
}