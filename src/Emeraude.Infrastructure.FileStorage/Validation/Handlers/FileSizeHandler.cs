using System;
using Emeraude.Essentials.Validation;
using Microsoft.AspNetCore.Http;

namespace Emeraude.Infrastructure.FileStorage.Validation.Handlers
{
    /// <summary>
    /// File validation handler for the size of the file.
    /// </summary>
    internal class FileSizeHandler : Handler<IFormFile>
    {
        private readonly long maxAllowedFileSize;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileSizeHandler"/> class.
        /// </summary>
        /// <param name="maxAllowedFileSize"></param>
        public FileSizeHandler(long maxAllowedFileSize)
        {
            if (maxAllowedFileSize == 0)
            {
                throw new NullReferenceException("Allowed file size must be greater than 0.");
            }

            this.maxAllowedFileSize = maxAllowedFileSize;
        }

        /// <inheritdoc/>
        protected override string HandleProcessAction()
        {
            string resultMessage = string.Empty;
            if (this.RequestObject.Length == 0)
            {
                this.RequestObject = null;
                resultMessage = $"File size must be greater than 0 bytes. ";
            }
            else if (this.RequestObject.Length > this.maxAllowedFileSize)
            {
                this.RequestObject = null;
                resultMessage = $"File size exceeds allowed {this.maxAllowedFileSize} bytes. ";
            }

            return resultMessage;
        }
    }
}
