using System.Threading;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Common.Interfaces.Files;
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

            /// <summary>
            /// Initializes a new instance of the <see cref="UploadVideoCommandHandler"/> class.
            /// </summary>
            /// <param name="validationProvider"></param>
            /// <param name="systemFilesService"></param>
            public UploadVideoCommandHandler(IFilesValidationProvider validationProvider, ISystemFilesService systemFilesService)
            {
                this.validationProvider = validationProvider;
                this.systemFilesService = systemFilesService;
            }

            /// <inheritdoc/>
            public async Task<UploadResult> Handle(UploadVideoCommand request, CancellationToken cancellationToken)
            {
                var validationResult = this.validationProvider.ValidateFormVideoFile(request.FormFile);
                if (validationResult.Successed)
                {
                    var uploadedFile = this.systemFilesService.UploadFileAsync(request.FormFile);
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
