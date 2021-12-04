using System.Threading.Tasks;
using Emeraude.Application.Admin.Adapters;
using Emeraude.Configuration.Extensions;
using Emeraude.Essentials.Base;
using Emeraude.Infrastructure.FileStorage.Services;
using Emeraude.Infrastructure.FileStorage.Validation;
using Emeraude.Infrastructure.Identity.Common;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Emeraude.Presentation.PortalGateway.Controllers.Admin;

/// <summary>
/// Admin authentication API controller.
/// </summary>
[Route("/_em/api/admin/general/")]
[Authorize(Policy = EmPermissions.AccessAdministrationPolicy)]
public class AdminGeneralApiController : EmPortalGatewayApiController
{
    private readonly IAdminMenusBuilder adminMenusBuilder;
    private readonly IFilesValidationProvider filesValidationProvider;
    private readonly IUploadService uploadService;

    /// <summary>
    /// Initializes a new instance of the <see cref="AdminGeneralApiController"/> class.
    /// </summary>
    /// <param name="adminMenusBuilder"></param>
    /// <param name="filesValidationProvider"></param>
    /// <param name="uploadService"></param>
    public AdminGeneralApiController(
        IAdminMenusBuilder adminMenusBuilder,
        IFilesValidationProvider filesValidationProvider,
        IUploadService uploadService)
    {
        this.adminMenusBuilder = adminMenusBuilder;
        this.filesValidationProvider = filesValidationProvider;
        this.uploadService = uploadService;
    }

    /// <summary>
    /// Gets admin menus.
    /// </summary>
    /// <returns></returns>
    [HttpGet("admin-menus")]
    public async Task<IActionResult> GetAdminMenus()
    {
        var adminMenus = await this.adminMenusBuilder.BuildAsync();
        return this.Ok(adminMenus);
    }

    /// <summary>
    /// Uploads a file with the default file validation.
    /// </summary>
    /// <param name="formFile"></param>
    /// <returns></returns>
    [HttpPost("files/upload")]
    public async Task<IActionResult> UploadFile([FromForm(Name = "file")] IFormFile formFile)
    {
        var validationResult = this.filesValidationProvider.ValidateFormFile(formFile);
        if (!validationResult.Succeeded)
        {
            return this.BadRequest(validationResult);
        }

        var result = await this.uploadService.UploadFileAsync(formFile);
        return this.Ok(new
        {
            TempFileId = result,
        });
    }

    /// <summary>
    /// Gets framework version.
    /// </summary>
    /// <returns></returns>
    [HttpGet("version")]
    public IActionResult GetFrameworkVersion()
    {
        var version = this.OptionsProvider.GetMainOptions().EmeraudeVersion;
        return this.Ok(new { Version = version });
    }
}