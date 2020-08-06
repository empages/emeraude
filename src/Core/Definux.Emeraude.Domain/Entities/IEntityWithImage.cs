namespace Definux.Emeraude.Domain.Entities
{
    public interface IEntityWithImage : IEntity
    {
        string ImageUrl { get; set; }
    }
}
