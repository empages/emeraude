namespace Definux.Emeraude.Domain.Entities
{
    /// <summary>
    /// Interface that represent domain entity with additional image.
    /// </summary>
    public interface IEntityWithImage : IEntity
    {
        /// <summary>
        /// Url of the image of the entity.
        /// </summary>
        string ImageUrl { get; set; }
    }
}
