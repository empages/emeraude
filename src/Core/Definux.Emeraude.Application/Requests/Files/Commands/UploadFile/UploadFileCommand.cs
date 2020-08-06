using Definux.Emeraude.Application.Common.Interfaces.Files;
using Definux.Emeraude.Application.Requests.Files.Commands.Shared;
using Definux.Emeraude.Domain.Logging;
using MediatR;
using Microsoft.AspNetCore.Http;
using System.Threading;
using System.Threading.Tasks;

namespace Definux.Emeraude.Application.Requests.Files.Commands.UploadFile
{
    public class UploadFileCommand : IRequest<UploadResult>
    {
        public UploadFileCommand(IFormFile formFile)
        {
            FormFile = formFile;
        }

        public UploadFileCommand(IFormFile formFile, string saveDirectory, bool publicRoot)
        {
            FormFile = formFile;
            SaveDirectory = saveDirectory;
            PublicRoot = publicRoot;
        }

        public string SaveDirectory { get; set; }

        public bool PublicRoot { get; set; }

        public IFormFile FormFile { get; set; }

        public class UploadFileCommandHandler : IRequestHandler<UploadFileCommand, UploadResult>
        {
            private readonly IFilesValidationProvider validationProvider;
            private readonly ISystemFilesService systemFilesService;

            public UploadFileCommandHandler(IFilesValidationProvider validationProvider, ISystemFilesService systemFilesService)
            {
                this.validationProvider = validationProvider;
                this.systemFilesService = systemFilesService;
            }

            public async Task<UploadResult> Handle(UploadFileCommand request, CancellationToken cancellationToken)
            {
                var validationResult = this.validationProvider.ValidateFormFile(request.FormFile);
                if (validationResult.Success)
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
