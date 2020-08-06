using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Application.Requests.Files.Commands.Shared
{
    public class UploadResult
    {
        public bool Success { get; set; }

        public string Message { get; set; }

        public bool ValidationError { get; set; }

        public static UploadResult SuccessResult => new UploadResult
        {
            Success = true
        };

        public static UploadResult ErrorResult => new UploadResult
        {
            Success = false
        };

        public static UploadResult ValidationErrorResult(string message) => new UploadResult
        {
            Success = false,
            Message = message,
            ValidationError = true
        };
    }
}