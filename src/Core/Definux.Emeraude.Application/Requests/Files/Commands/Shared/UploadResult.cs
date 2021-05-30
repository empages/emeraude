namespace Definux.Emeraude.Application.Requests.Files.Commands.Shared
{
    /// <summary>
    /// Upload result used for files upload commands.
    /// </summary>
    public class UploadResult
    {
        /// <summary>
        /// Boolean status of the result.
        /// </summary>
        public bool Success { get; set; }

        /// <summary>
        /// Message of the result.
        /// </summary>
        public string Message { get; set; }

        /// <summary>
        /// Boolean status that indicates that the file is not uploaded because of validation error.
        /// </summary>
        public bool ValidationError { get; set; }

        /// <summary>
        /// Temp file result id.
        /// </summary>
        public int ResultFileId { get; set; }

        /// <summary>
        /// Built upload success result.
        /// </summary>
        /// <param name="tempFileId"></param>
        /// <returns></returns>
        public static UploadResult SuccessResult(int tempFileId) => new UploadResult
        {
            Success = true,
            ResultFileId = tempFileId,
        };

        /// <summary>
        /// Built upload error result.
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static UploadResult ErrorResult(string errorMessage) => new UploadResult
        {
            Success = false,
            Message = errorMessage,
        };

        /// <summary>
        /// Built upload error result with message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static UploadResult ValidationErrorResult(string message) => new UploadResult
        {
            Success = false,
            Message = message,
            ValidationError = true,
        };
    }
}