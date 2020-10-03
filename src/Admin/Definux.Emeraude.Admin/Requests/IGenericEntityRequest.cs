namespace Definux.Emeraude.Admin.Requests
{
    /// <summary>
    /// Definition of generic entity request.
    /// </summary>
    public interface IGenericEntityRequest
    {
        /// <summary>
        /// Flag that indicates whether the entity has valid parent reference or not.
        /// </summary>
        bool ValidateParent { get; }

        /// <summary>
        /// Referenced property name of the parent entity for current entity.
        /// </summary>
        string ForeignKeyProperty { get; set; }

        /// <summary>
        /// Referenced property value of the parent entity for current entity.
        /// </summary>
        string ForeignKeyValue { get; set; }
    }
}
