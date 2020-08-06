using Definux.Emeraude.Admin.Controllers.Abstractions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Definux.Utilities.Extensions;
using Definux.Emeraude.Admin.UI.ViewModels.Roots;
using Definux.Emeraude.Admin.UI.ViewModels.Layout;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Application.Requests.Files.Commands.UploadFile;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Common.Results.Files;
using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Presentation.Extensions;

namespace Definux.Emeraude.Admin.Controllers.Mvc
{
    [Route("/admin/roots/")]
    [ApiExplorerSettings(IgnoreApi = true)]
    [Authorize(Policy = AdminPermissions.AccessAdministrationPolicy)]
    [Authorize(Policy = AdminPermissions.RootAccessPolicy)]
    public sealed class AdminRootsController : AdminController
    {
        private readonly ISystemFilesService systemFilesService;
        public AdminRootsController(ISystemFilesService systemFilesService)
        {
            this.systemFilesService = systemFilesService;
        }

        [HttpGet]
        [Route("{root:root}/{*folders}")]
        public IActionResult Root(string root, string folders = "")
        {
            try
            {
                IEnumerable<SystemFileItem> fileSystemItems = null;
                RootViewModel model = null;
                string folderPath = folders.Replace('/', Path.DirectorySeparatorChar);
                fileSystemItems = this.systemFilesService.ScanDirectory(Path.Combine(GetRootDirectory(root), folderPath), GetRootDirectory(root));
                model = RootMapper.Map(folderPath, fileSystemItems);

                model.Root = root.ToFirstUpper();
                InitializeNavigationActions(BuildNavigationActions(folders, root));

                return View("Root", model);
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("{root:root}/file/{*folders}")]
        public async Task<IActionResult> RootFile(string root, string folders = "")
        {
            try
            {
                IActionResult result = NotFound();
                if (folders != null)
                {
                    string filePath = folders.Replace('/', Path.DirectorySeparatorChar);
                    var fileResult = await this.systemFilesService.GetFileAsync(Path.Combine(GetRootDirectory(root), filePath));

                    result = File(fileResult.Stream, fileResult.ContentType);
                }

                return result;
            }
            catch (System.Exception)
            {
                return NotFound();
            }
        }

        [HttpGet]
        [Route("{root:root}/create-folder/{*folders}")]
        public IActionResult CreateFolder(string root, string folders = "")
        {
            RootCreateFolderViewModel model = new RootCreateFolderViewModel();
            model.ParentFolderPath = folders;
            model.Root = root.ToFirstUpper();

            return View(model);
        }

        [HttpPost]
        [Route("{root:root}/create-folder")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> CreateFolder(string root, RootCreateFolderViewModel model)
        {
            if (ModelState.IsValid)
            {
                model.Root = root.ToFirstUpper();

                bool created = await this.systemFilesService.CreateFolderAsync(model.FolderName, Path.Combine(GetRootDirectory(root), model.ParentFolderPath));
                if (created)
                {
                    string foldersRoute = string.IsNullOrEmpty(model.ParentFolderPath) ? string.Empty : "/" + model.ParentFolderPath.Replace("\\", "/");
                    return LocalRedirect($"/admin/roots/{root}{foldersRoute}/{model.FolderName}");
                }

                ModelState.AddModelError(nameof(RootCreateFolderViewModel.FolderName), $"Folder with name '{model.FolderName}' cannot be created.");
            }

            return View(model);
        }

        [HttpGet]
        [Route("{root:root}/upload-files/{*folders}")]
        public IActionResult UploadFiles(string root, string folders = "")
        {
            RootUploadFilesViewModel model = new RootUploadFilesViewModel();
            model.ParentFolderPath = folders;
            model.Root = root.ToFirstUpper();

            return View(model);
        }

        [HttpPost]
        [Route("{root:root}/upload-file/")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> UploadFile(string root, [FromForm(Name = "file")]IFormFile formFile, RootUploadFilesViewModel model)
        {
            model.Root = root.ToFirstUpper();

            string saveDirectory = model.ParentFolderPath.Replace('/', Path.DirectorySeparatorChar);
            bool publicRoot = root == "public";

            return this.UploadFileResponse(await Mediator.Send(new UploadFileCommand(formFile, saveDirectory, publicRoot)));
        }

        private string GetRootDirectory(string root)
        {
            string directory = string.Empty;
            if (root == "public")
            {
                directory = this.systemFilesService.PublicRootDirectory;
            }
            else if (root == "private")
            {
                directory = this.systemFilesService.PrivateRootDirectory;
            }

            return directory;
        }

        private List<NavigationActionViewModel> BuildNavigationActions(string folders, string root)
        {
            var actions = new List<NavigationActionViewModel>();

            actions.Add(new NavigationActionViewModel
            {
                Name = $"Create a folder",
                ActionUrl = $"/admin/roots/{root}/create-folder/{folders}",
                Icon = MaterialDesignIcons.FolderPlus,
                Method = System.Net.Http.HttpMethod.Get,
            });

            actions.Add(new NavigationActionViewModel
            {
                Name = $"Upload files",
                ActionUrl = $"/admin/roots/{root}/upload-files/{string.Join("/", folders)}",
                Icon = MaterialDesignIcons.Upload,
                Method = System.Net.Http.HttpMethod.Get,
            });

            return actions;
        }
    }
}
