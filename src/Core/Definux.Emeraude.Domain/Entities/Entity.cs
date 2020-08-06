using System;

namespace Definux.Emeraude.Domain.Entities
{
    public abstract class Entity : IEntity
    {
        public Guid Id { get; set; }
    }
}
