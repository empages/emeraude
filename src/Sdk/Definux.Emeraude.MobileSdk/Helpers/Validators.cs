using System.Linq;
using System.Net.Mail;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Resources;

namespace Definux.Emeraude.MobileSdk.Helpers
{
    /// <summary>
    /// Built validators for strings and parameters.
    /// </summary>
    public static class Validators
    {
        /// <summary>
        /// Check validity of email address.
        /// </summary>
        /// <param name="email"></param>
        /// <param name="errorMessage"></param>
        /// <returns></returns>
        public static bool IsValidEmail(string email, out string errorMessage)
        {
            try
            {
                errorMessage = null;
                if (string.IsNullOrWhiteSpace(email))
                {
                    errorMessage = Messages.EmailIsARequiredField;
                    return false;
                }

                var address = new MailAddress(email);
                return address.Address == email;
            }
            catch
            {
                errorMessage = Messages.EnteredEmailIsInTheWrongFormat;
                return false;
            }
        }

        /// <summary>
        /// Check validity of password based on Emeraude framework requirements.
        /// </summary>
        /// <param name="password"></param>
        /// <param name="errorMessage"></param>
        /// <param name="minLength"></param>
        /// <returns></returns>
        public static bool IsValidPassword(string password, out string errorMessage, int minLength = EmIdentityConstants.PasswordRequiredLength)
        {
            errorMessage = null;

            if (string.IsNullOrWhiteSpace(password))
            {
                errorMessage = Messages.PasswordIsARequiredField;
                return false;
            }

            if (password.Length < EmIdentityConstants.PasswordRequiredLength)
            {
                errorMessage = string.Format(Messages.PasswordMustBeAtLeastSymbols, EmIdentityConstants.PasswordRequiredLength);
                return false;
            }

            if (!password.Any(x => char.IsDigit(x)))
            {
                errorMessage = Messages.PasswordHaveToContainsAtLeast1Digit;
                return false;
            }

            if (!password.Any(x => char.IsLetter(x)))
            {
                errorMessage = Messages.PasswordHaveToContainsAtLeast1Letter;
                return false;
            }

            return true;
        }
    }
}
