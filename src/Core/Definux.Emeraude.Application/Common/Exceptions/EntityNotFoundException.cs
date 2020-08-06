using System;

namespace Definux.Emeraude.Application.Common.Exceptions
{
    public class EntityNotFoundException : Exception
    {
        public EntityNotFoundException(string entity, Guid identifier)
            : base($"{entity} with id {identifier} have not been found.")
        {

        }

        public EntityNotFoundException(string message)
            : base(message)
        {

        }
    }
}
