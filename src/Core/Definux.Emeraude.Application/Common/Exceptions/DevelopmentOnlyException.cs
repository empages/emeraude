using System;

namespace Definux.Emeraude.Application.Common.Exceptions
{
    public class DevelopmentOnlyException : UnauthorizedAccessException
    {
        public DevelopmentOnlyException()
        {

        }

        public DevelopmentOnlyException(string message)
            : base(message)
        {

        }
    }
}
