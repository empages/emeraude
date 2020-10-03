namespace Definux.Emeraude.Application.Common.Results.Emails
{
    /// <summary>
    /// Result model used on sending email operation.
    /// </summary>
    public class SendEmailResult
    {
        /// <summary>
        /// Built result for success.
        /// </summary>
        public static SendEmailResult SuccessResult => new SendEmailResult { Success = true };

        /// <summary>
        /// Built result for failure.
        /// </summary>
        public static SendEmailResult FailedResult => new SendEmailResult { Success = false };

        /// <summary>
        /// Boolean status which set success or failure for the result.
        /// </summary>
        public bool Success { get; set; }
    }
}
