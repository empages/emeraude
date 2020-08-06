using System.IO;

namespace Definux.Emeraude.Application.Common.Results.Files
{
    public class SystemFileResult
    {
        public FileStream Stream { get; set; }

        public string ContentType { get; set; }
    }
}
