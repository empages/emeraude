using System;
using System.Collections.Generic;
using Definux.Utilities.Validation;
using Microsoft.AspNetCore.Http;

namespace Definux.Emeraude.Infrastructure.FileStorage.Validation.Handlers
{
    /// <summary>
    /// File validation handler for MIME types.
    /// </summary>
    internal class FileMimeTypesHandler : Handler<IFormFile>
    {
        private List<string> allowedMimeTypes;

        /// <summary>
        /// Initializes a new instance of the <see cref="FileMimeTypesHandler"/> class.
        /// </summary>
        /// <param name="allowedMimeTypes"></param>
        public FileMimeTypesHandler(List<string> allowedMimeTypes)
        {
            if (allowedMimeTypes == null || allowedMimeTypes.Count == 0)
            {
                throw new NullReferenceException("Allowed mime types list must be valid list with at least 1 element in.");
            }

            this.allowedMimeTypes = allowedMimeTypes;
        }

        /// <inheritdoc/>
        protected override string HandleProcessAction()
        {
            bool isFileValid = false;
            foreach (var mimeType in this.allowedMimeTypes)
            {
                if (this.RequestObject.ContentType.Equals(mimeType, StringComparison.OrdinalIgnoreCase))
                {
                    isFileValid = true;
                    break;
                }
            }

            string resultMessage = string.Empty;
            if (!isFileValid)
            {
                this.RequestObject = null;
                resultMessage = "File mime type is incorrect. ";
            }

            return resultMessage;
        }
    }
}
