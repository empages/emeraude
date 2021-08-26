using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Definux.Emeraude.Configuration.Options;
using Definux.Utilities.DataAnnotations;
using Definux.Utilities.DataAnnotations.Helpers;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;

namespace Definux.Emeraude.Presentation.Attributes
{
    public class GoogleReCaptchaValidateAttribute : ActionFilterAttribute
    {
                /// <summary>
        /// ReCaptcha Model state error key.
        /// </summary>
        public const string ReCaptchaModelErrorKey = "ReCaptcha";

        private const string RecaptchaResponseTokenKey = "g-recaptcha-response";
        private const string ApiVerificationEndpoint = "https://www.google.com/recaptcha/api/siteverify";
        private readonly IHostingEnvironment hostingEnvironment;

        /// <summary>
        /// Initializes a new instance of the <see cref="GoogleReCaptchaValidateAttribute"/> class.
        /// </summary>
        /// <param name="googleRecaptchaKeysConfiguration"></param>
        /// <param name="hostingEnvironment"></param>
        public GoogleReCaptchaValidateAttribute(IOptions<GoogleRecaptchaKeysOptions> googleRecaptchaKeysConfiguration, IHostingEnvironment hostingEnvironment)
        {
            this.GoogleRecaptchaKeys = googleRecaptchaKeysConfiguration.Value;
            this.ReCaptchaSecret = new Lazy<string>(() => this.GoogleRecaptchaKeys.SecretKey);
            this.hostingEnvironment = hostingEnvironment;
        }

        /// <summary>
        /// Flag that turn on/off validation for development environment.
        /// </summary>
        public bool VerifyInDevelopment { get; protected set; }

        /// <summary>
        /// Options implementation for Google ReCaptcha.
        /// </summary>
        protected GoogleRecaptchaKeysOptions GoogleRecaptchaKeys { get; set; }

        /// <summary>
        /// ReCaptcha secret key.
        /// </summary>
        protected Lazy<string> ReCaptchaSecret { get; set; }

        /// <inheritdoc/>
        public override async Task OnActionExecutionAsync(ActionExecutingContext context, ActionExecutionDelegate next)
        {
            await this.DoReCaptchaValidation(context);
            await base.OnActionExecutionAsync(context, next);
        }

        private static void AddModelError(ActionExecutingContext context, string error)
        {
            context.ModelState.AddModelError(ReCaptchaModelErrorKey, error.ToString());
        }

        private async Task DoReCaptchaValidation(ActionExecutingContext context)
        {
            if (!this.VerifyInDevelopment && this.hostingEnvironment.IsDevelopment())
            {
                return;
            }

            string token = null;

            if (context.HttpContext.Request.HasFormContentType && context.HttpContext.Request.Form.ContainsKey(RecaptchaResponseTokenKey))
            {
                token = context.HttpContext.Request.Form[RecaptchaResponseTokenKey];
            }
            else if (context.HttpContext.Request.Headers.ContainsKey(RecaptchaResponseTokenKey))
            {
                token = context.HttpContext.Request.Headers[RecaptchaResponseTokenKey];
            }

            if (string.IsNullOrWhiteSpace(token))
            {
                AddModelError(context, "No reCaptcha Token Found");
            }
            else
            {
                await this.ValidateRecaptcha(context, token);
            }
        }

        private async Task ValidateRecaptcha(ActionExecutingContext context, string token)
        {
            using (var webClient = new HttpClient())
            {
                var content = new FormUrlEncodedContent(new[]
                {
                    new KeyValuePair<string, string>("secret", this.ReCaptchaSecret.Value),
                    new KeyValuePair<string, string>("response", token),
                });
                HttpResponseMessage response = await webClient.PostAsync(ApiVerificationEndpoint, content);
                string json = await response.Content.ReadAsStringAsync();
                var reCaptchaResponse = JsonConvert.DeserializeObject<ReCaptchaResponse>(json);
                if (reCaptchaResponse == null)
                {
                    AddModelError(context, "Unable To Read Response From Server");
                }
                else if (!reCaptchaResponse.Success)
                {
                    AddModelError(context, "Invalid reCaptcha");
                }
            }
        }
    }
}