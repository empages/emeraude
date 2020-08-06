namespace Definux.Emeraude.Application.Common.Results.Emails
{
    public class SendEmailResult
    {
        public bool Success { get; set; }

        public static SendEmailResult SuccessResult => new SendEmailResult { Success = true };

        public static SendEmailResult FailedResult => new SendEmailResult { Success = false };
    }
}
