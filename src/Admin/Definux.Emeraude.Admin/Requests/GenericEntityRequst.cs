namespace Definux.Emeraude.Admin.Requests
{
    /// <summary>
    /// Implementation of generic entity request.
    /// </summary>
    public abstract class GenericEntityRequst : IGenericEntityRequest
    {
        /// <inheritdoc/>
        public bool ValidateParent
        {
            get
            {
                return !string.IsNullOrWhiteSpace(this.ForeignKeyProperty) && !string.IsNullOrWhiteSpace(this.ForeignKeyValue);
            }
        }

        /// <inheritdoc/>
        public string ForeignKeyProperty { get; set; }

        /// <inheritdoc/>
        public string ForeignKeyValue { get; set; }
    }
}
