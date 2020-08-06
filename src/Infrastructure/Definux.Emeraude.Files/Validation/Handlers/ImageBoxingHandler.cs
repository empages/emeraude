using Definux.Utilities.Validation;
using ImageMagick;
using Microsoft.AspNetCore.Http;
using System;

namespace Definux.Emeraude.Files.Validation.Handlers
{
    internal class ImageBoxingHandler : Handler<IFormFile>
    {
        protected override string HandleProcessAction()
        {
            string resultMessage = string.Empty;
            try
            {
                using (MagickImage image = new MagickImage(this.requestObject.OpenReadStream()))
                {
                }
            }
            catch (Exception)
            {
                this.requestObject = null;
                resultMessage = $"File content cannot be used as an image. ";
            }

            return resultMessage;
        }
    }
}
