using Definux.Emeraude.Application.Emails;

namespace EmDoggo.Application.Emails
{
    public class ResetPasswordEmailModel : EmailModel
    {
        public string ResetPasswordLink { get; set; }
    }
}