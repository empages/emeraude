using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.General.Models;
using Definux.Emeraude.Infrastructure.FileStorage.Services;
using Definux.Emeraude.Infrastructure.FileStorage.Validation;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.General.Requests.Commands.UploadFile
{
    /// <summary>
    /// Command for uploading files.
    /// </summary>
    public class UploadFileCommand : IRequest<UploadResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileCommand"/> class.
        /// </summary>
        /// <param name="formFile"></param>
        public UploadFileCommand(IFormFile formFile)
        {
            this.FormFile = formFile;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="UploadFileCommand"/> class.
        /// </summary>
        /// <param name="formFile"></param>
        /// <param name="saveDirectory"></param>
        /// <param name="publicRoot"></param>
        public UploadFileCommand(IFormFile formFile, string saveDirectory, bool publicRoot)
        {
            this.FormFile = formFile;
            this.SaveDirectory = saveDirectory;
            this.PublicRoot = publicRoot;
        }

        /// <summary>
        /// Save directory of the file.
        /// </summary>
        public string SaveDirectory { get; set; }

        /// <summary>
        /// Flag that indicates whether the target root is public (for true) or private (for false).
        /// </summary>
        public bool PublicRoot { get; set; }

        /// <inheritdoc cref="IFormFile"/>
        public IFormFile FormFile { get; set; }

        /// <inheritdoc/>
        public class UploadFileCommandHandler : IRequestHandler<UploadFileCommand, UploadResult>
        {
            private readonly IFilesValidationProvider validationProvider;
            private readonly IUploadService uploadService;

            /// <summary>
            /// Initializes a new instance of the <see cref="UploadFileCommandHandler"/> class.
            /// </summary>
            /// <param name="validationProvider"></param>
            /// <param name="uploadService"></param>
            public UploadFileCommandHandler(
                IFilesValidationProvider validationProvider,
                IUploadService uploadService)
            {
                this.validationProvider = validationProvider;
                this.uploadService = uploadService;
            }

            /// <inheritdoc/>
            public async Task<UploadResult> Handle(UploadFileCommand request, CancellationToken cancellationToken)
            {
                var validationResult = this.validationProvider.ValidateFormFile(request.FormFile);
                if (!validationResult.Succeeded)
                {
                    return UploadResult.ValidationErrorResult(validationResult.Message);
                }

                string uploadedFile;
                if (string.IsNullOrEmpty(request.SaveDirectory))
                {
                    uploadedFile = await this.uploadService.UploadFileAsync(request.FormFile);
                }
                else
                {
                    uploadedFile = await this.uploadService.UploadFileAsync(request.FormFile, request.SaveDirectory, request.PublicRoot);
                }

                return uploadedFile != null ? UploadResult.SuccessResult(uploadedFile) : UploadResult.ErrorResult("File has not been uploaded.");
            }
        }
    }
}