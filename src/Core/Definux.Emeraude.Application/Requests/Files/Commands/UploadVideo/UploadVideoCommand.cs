using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Files;
using Definux.Emeraude.Application.Requests.Files.Commands.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo
{
    /// <summary>
    /// Command for uploading video files.
    /// </summary>
    public class UploadVideoCommand : IRequest<UploadResult>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="UploadVideoCommand"/> class.
        /// </summary>
        /// <param name="formFile"></param>
        public UploadVideoCommand(IFormFile formFile)
        {
            this.FormFile = formFile;
        }

        /// <inheritdoc cref="IFormFile"/>
        public IFormFile FormFile { get; set; }

        /// <inheritdoc/>
        public class UploadVideoCommandHandler : IRequestHandler<UploadVideoCommand, UploadResult>
        {
            private readonly IFilesValidationProvider validationProvider;
            private readonly ISystemFilesService systemFilesService;
            private readonly IUploadService uploadService;

            /// <summary>
            /// Initializes a new instance of the <see cref="UploadVideoCommandHandler"/> class.
            /// </summary>
            /// <param name="validationProvider"></param>
            /// <param name="systemFilesService"></param>
            /// <param name="uploadService"></param>
            public UploadVideoCommandHandler(
                IFilesValidationProvider validationProvider,
                ISystemFilesService systemFilesService,
                IUploadService uploadService)
            {
                this.validationProvider = validationProvider;
                this.systemFilesService = systemFilesService;
                this.uploadService = uploadService;
            }

            /// <inheritdoc/>
            public async Task<UploadResult> Handle(UploadVideoCommand request, CancellationToken cancellationToken)
            {
                var validationResult = this.validationProvider.ValidateFormVideoFile(request.FormFile);
                if (validationResult.Successed)
                {
                    var uploadedFile = await this.uploadService.UploadFileAsync(request.FormFile);
                    if (uploadedFile != null)
                    {
                        return UploadResult.SuccessResult(uploadedFile.Id);
                    }
                    else
                    {
                        return UploadResult.ErrorResult("File has not been uploaded.");
                    }
                }

                return UploadResult.ValidationErrorResult(validationResult.Message);
            }
        }
    }
}
