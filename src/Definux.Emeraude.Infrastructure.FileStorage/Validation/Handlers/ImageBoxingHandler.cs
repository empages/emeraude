using System;
using Definux.Utilities.Validation;
using ImageMagick;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Infrastructure.FileStorage.Validation.Handlers
{
    /// <summary>
    /// File validation handler that check whether a file can be cast to a image.
    /// </summary>
    internal class ImageBoxingHandler : Handler<IFormFile>
    {
        /// <inheritdoc/>
        protected override string HandleProcessAction()
        {
            string resultMessage = string.Empty;
            try
            {
                using (MagickImage image = new MagickImage(this.RequestObject.OpenReadStream()))
                {
                }
            }
            catch (Exception)
            {
                this.RequestObject = null;
                resultMessage = $"File content cannot be used as an image. ";
            }

            return resultMessage;
        }
    }
}
