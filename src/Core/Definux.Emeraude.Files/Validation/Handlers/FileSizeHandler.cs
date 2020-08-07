using Definux.Utilities.Validation;
using Microsoft.AspNetCore.Http;
using System;

namespace Definux.Emeraude.Files.Validation.Handlers
{
    internal class FileSizeHandler : Handler<IFormFile>
    {
        private readonly long maxAllowedFileSize;

        public FileSizeHandler(long maxAllowedFileSize)
        {
            if (maxAllowedFileSize == 0)
            {
                throw new NullReferenceException("Allowed file size must be greater than 0.");
            }
            this.maxAllowedFileSize = maxAllowedFileSize;
        }
        protected override string HandleProcessAction()
        {
            string resultMessage = string.Empty;
            if (this.requestObject.Length == 0)
            {
                this.requestObject = null;
                resultMessage = $"File size must be greater than 0 bytes. ";
            }
            else if (this.requestObject.Length > this.maxAllowedFileSize)
            {
                this.requestObject = null;
                resultMessage = $"File size exceeds allowed {maxAllowedFileSize} bytes. ";
            }

            return resultMessage;
        }
    }
}
