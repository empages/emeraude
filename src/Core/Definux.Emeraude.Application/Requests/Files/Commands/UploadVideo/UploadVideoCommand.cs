using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Application.Requests.Files.Commands.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Files.Commands.UploadVideo
{
    public class UploadVideoCommand : IRequest<UploadResult>
    {
        public UploadVideoCommand(IFormFile formFile)
        {
            FormFile = formFile;
        }

        public IFormFile FormFile { get; set; }

        public class UploadVideoCommandHandler : IRequestHandler<UploadVideoCommand, UploadResult>
        {
            private readonly IFilesValidationProvider validationProvider;
            private readonly ISystemFilesService systemFilesService;

            public UploadVideoCommandHandler(IFilesValidationProvider validationProvider, ISystemFilesService systemFilesService)
            {
                this.validationProvider = validationProvider;
                this.systemFilesService = systemFilesService;
            }

            public async Task<UploadResult> Handle(UploadVideoCommand request, CancellationToken cancellationToken)
            {
                var validationResult = this.validationProvider.ValidateFormVideoFile(request.FormFile);
                if (validationResult.Success)
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
