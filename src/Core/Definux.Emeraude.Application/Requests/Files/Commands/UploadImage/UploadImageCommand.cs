using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Application.Requests.Files.Commands.Shared;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Files.Commands.UploadImage
{
    public class UploadImageCommand : IRequest<UploadResult>
    {
        public UploadImageCommand(IFormFile formFile)
        {
            FormFile = formFile;
        }

        public IFormFile FormFile { get; set; }

        public class UploadImageCommandHandler : IRequestHandler<UploadImageCommand, UploadResult>
        {
            private readonly IFilesValidationProvider validationProvider;
            private readonly ISystemFilesService systemFilesService;

            public UploadImageCommandHandler(IFilesValidationProvider validationProvider, ISystemFilesService systemFilesService)
            {
                this.validationProvider = validationProvider;
                this.systemFilesService = systemFilesService;
            }

            public async Task<UploadResult> Handle(UploadImageCommand request, CancellationToken cancellationToken)
            {
                var validationResult = this.validationProvider.ValidateFormImageFile(request.FormFile);
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
