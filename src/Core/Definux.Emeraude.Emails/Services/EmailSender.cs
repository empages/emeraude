using System;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using Definux.Emeraude.Application.Emails;
using Definux.Emeraude.Application.Logger;
using Definux.Utilities.Options;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Abstractions;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.Razor;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Routing;
using Microsoft.Extensions.Options;

namespace Definux.Emeraude.Emails.Services
{
    /// <inheritdoc cref="IEmailSender"/>
    public class EmailSender : IEmailSender
    {
        private readonly IEmailRenderer emailRenderer;
        private readonly IEmLogger logger;
        private readonly SmtpOptions smtpOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmailSender"/> class.
        /// </summary>
        /// <param name="emailRenderer"></param>
        /// <param name="logger"></param>
        /// <param name="smtpOptionsAccessor"></param>
        public EmailSender(
            IEmailRenderer emailRenderer,
            IEmLogger logger,
            IOptions<SmtpOptions> smtpOptionsAccessor)
        {
            this.emailRenderer = emailRenderer;
            this.logger = logger;
            this.smtpOptions = smtpOptionsAccessor.Value;
        }

        /// <inheritdoc/>
        public async Task<SendEmailResult> SendEmailAsync(string templateName, EmailModel model)
        {
            bool sent = false;
            SendEmailResult emailResult = SendEmailResult.FailedResult;
            string message = string.Empty;
            try
            {
                message = await this.emailRenderer.RenderToStringAsync(templateName, model);

                SmtpClient client = new SmtpClient(this.smtpOptions.Host);
                client.UseDefaultCredentials = false;
                client.Credentials = new NetworkCredential(this.smtpOptions.Username, this.smtpOptions.Password);
                client.Port = this.smtpOptions.Port;
                client.EnableSsl = this.smtpOptions.UseSSL;

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(this.smtpOptions.EmailAddress, this.smtpOptions.Name);
                mailMessage.To.Add(model.Email);
                mailMessage.Body = message;
                mailMessage.IsBodyHtml = true;
                mailMessage.BodyEncoding = System.Text.Encoding.UTF8;
                mailMessage.Subject = model.Subject;
                client.Send(mailMessage);

                emailResult = SendEmailResult.SuccessResult;
                sent = true;
            }
            catch (Exception ex)
            {
                await this.logger.LogErrorAsync(ex);
            }

            await this.logger.LogEmailAsync(model.Email, model.Name, model.Subject, message, sent);
            return emailResult;
        }
    }
}