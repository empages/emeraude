namespace Definux.Emeraude.Application.Requests.Files.Commands.Shared
{
    /// <summary>
    /// Upload result used for files upload commands.
    /// </summary>
    public class UploadResult
    {
        /// <summary>
        /// Built upload success result.
        /// </summary>
        public static UploadResult SuccessResult => new UploadResult
        {
            Success = true,
        };

        /// <summary>
        /// Built upload error result.
        /// </summary>
        public static UploadResult ErrorResult => new UploadResult
        {
            Success = false,
        };

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