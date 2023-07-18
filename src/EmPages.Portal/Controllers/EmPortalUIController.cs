using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace EmPages.Portal.Controllers;

/// <summary>
/// Portal controller that contains the UI specific actions.
/// </summary>
[ApiExplorerSettings(IgnoreApi = true)]
public class EmPortalController : ControllerBase
{
    /// <summary>
    /// Portal UI accessor.
    /// </summary>
    /// <returns></returns>
    [HttpGet]
    [Route(EmPortalConstants.RoutePrefix)]
    [Route($"{EmPortalConstants.RoutePrefix}/**")]
    public async Task<IActionResult> Index()
    {
        var template = new UI.EmPages()
        {
            Session = new Dictionary<string, object>
            {
                { "Styles", ReadAssemblyFile("_EmPages.css") },
                { "Scripts", ReadAssemblyFile("_EmPages.js") },
            },
        };

        return this.Content(template.TransformText(), "text/html");
    }

    private static string ReadAssemblyFile(string fileName)
    {
        var assembly = Assembly.GetExecutingAssembly();
        var resourceName = assembly.GetManifestResourceNames().Single(x => x.EndsWith(fileName));
        using var stream = assembly.GetManifestResourceStream(resourceName);
        using var reader = new StreamReader(stream);
        return reader.ReadToEnd();
    }
}