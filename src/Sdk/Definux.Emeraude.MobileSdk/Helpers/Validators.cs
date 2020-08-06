using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Resources;
using System.Linq;
using System.Net.Mail;

namespace Definux.Emeraude.MobileSdk.Helpers
{
    public static class Validators
    {
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

        public static bool IsValidPassword(string password, out string errorMessage)
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
