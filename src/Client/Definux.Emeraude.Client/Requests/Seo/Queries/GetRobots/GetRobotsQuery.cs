using System;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Hosting;

namespace Definux.Emeraude.Client.Requests.Seo.Queries.GetRobots
{
    /// <summary>
    /// Query for getting the robots.txt of the application.
    /// </summary>
    public class GetRobotsQuery : IRequest<string>
    {
        /// <inheritdoc/>
        public class GetRobotsQueryHandler : IRequestHandler<GetRobotsQuery, string>
        {
            private const string RobotsTxtFileName = "robots.txt";
            private readonly string contentRootPath;

            /// <summary>
            /// Initializes a new instance of the <see cref="GetRobotsQueryHandler"/> class.
            /// </summary>
            /// <param name="hostingEnvironment"></param>
            public GetRobotsQueryHandler(IWebHostEnvironment hostingEnvironment)
            {
                this.contentRootPath = hostingEnvironment.ContentRootPath;
            }

            /// <inheritdoc/>
            public async Task<string> Handle(GetRobotsQuery request, CancellationToken cancellationToken)
            {
                try
                {
                    string filePath = Path.Combine(this.contentRootPath, RobotsTxtFileName);
                    if (!File.Exists(filePath))
                    {
                        throw new FileNotFoundException("The robots.txt was not found in the content root path of the application.");
                    }

                    string fileContent = await File.ReadAllTextAsync(filePath, cancellationToken);

                    return fileContent;
                }
                catch (Exception)
                {
                    return string.Empty;
                }
            }
        }
    }
}