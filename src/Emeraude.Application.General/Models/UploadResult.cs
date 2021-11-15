namespace Emeraude.Application.General.Models
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
        /// Temp file path.
        /// </summary>
        public string ResultFile { get; set; }

        /// <summary>
        /// Built upload success result.
        /// </summary>
        /// <param name="filePath"></param>
        /// <returns></returns>
        public static UploadResult SuccessResult(string filePath) => new ()
        {
            Success = true,
            ResultFile = filePath,
        };

        /// <summary>
        /// Built upload error result.
        /// </summary>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static UploadResult ErrorResult(string errorMessage) => new ()
        {
            Success = false,
            Message = errorMessage,
        };

        /// <summary>
        /// Built upload error result with message.
        /// </summary>
        /// <param name="message"></param>
        /// <returns></returns>
        public static UploadResult ValidationErrorResult(string message) => new ()
        {
            Success = false,
            Message = message,
            ValidationError = true,
        };
    }
}