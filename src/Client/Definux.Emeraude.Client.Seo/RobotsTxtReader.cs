using System;
using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Client.Seo
{
    /// <inheritdoc cref="IRobotsTxtReader"/>
    public sealed class RobotsTxtReader : IRobotsTxtReader
    {
        private const string RobotsTxtFileName = "robots.txt";
        private readonly string contentRootPath;

        /// <summary>
        /// Initializes a new instance of the <see cref="RobotsTxtReader"/> class.
        /// </summary>
        /// <param name="hostingEnvironment"></param>
        public RobotsTxtReader(IHostingEnvironment hostingEnvironment)
        {
            this.contentRootPath = hostingEnvironment.ContentRootPath;
        }

        /// <inheritdoc/>
        public string GetRobotsTxt()
        {
            try
            {
                string filePath = Path.Combine(this.contentRootPath, RobotsTxtFileName);
                if (!File.Exists(filePath))
                {
                    throw new FileNotFoundException("The robots.txt was not found in the content root path of the application.");
                }

                string fileContent = File.ReadAllText(filePath);

                return fileContent;
            }
            catch (Exception)
            {
                return string.Empty;
            }
        }
    }
}
