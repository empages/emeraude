using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Requests.Files.Commands.Shared;
using Definux.Emeraude.Domain.Logging;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.Requests.Files.Commands.UploadFile
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
            private readonly ISystemFilesService systemFilesService;

            /// <summary>
            /// Initializes a new instance of the <see cref="UploadFileCommandHandler"/> class.
            /// </summary>
            /// <param name="validationProvider"></param>
            /// <param name="systemFilesService"></param>
            public UploadFileCommandHandler(IFilesValidationProvider validationProvider, ISystemFilesService systemFilesService)
            {
                this.validationProvider = validationProvider;
                this.systemFilesService = systemFilesService;
            }

            /// <inheritdoc/>
            public async Task<UploadResult> Handle(UploadFileCommand request, CancellationToken cancellationToken)
            {
                var validationResult = this.validationProvider.ValidateFormFile(request.FormFile);
                if (validationResult.Successed)
                {
                    TempFileLog uploadedFile;
                    if (string.IsNullOrEmpty(request.SaveDirectory))
                    {
                        uploadedFile = await this.systemFilesService.UploadFileAsync(request.FormFile);
                    }
                    else
                    {
                        uploadedFile = await this.systemFilesService.UploadFileAsync(request.FormFile, request.SaveDirectory, request.PublicRoot);
                    }

                    if (uploadedFile != null)
                    {
                        return UploadResult.SuccessResult;
                    }
                    else
                    {
                        return UploadResult.ErrorResult;
                    }
                }

                return UploadResult.ValidationErrorResult(validationResult.Message);
            }
        }
    }
}