using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Create
{
    /// <inheritdoc cref="ICreateCommand{TEntity, TRequestModel}"/>
    public class CreateCommand<TEntity, TRequestModel> : GenericEntityRequst, ICreateCommand<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommand{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="model"></param>
        public CreateCommand(TRequestModel model)
        {
            this.Model = model;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CreateCommand{TEntity, TRequestModel}"/> class.
        /// </summary>
        /// <param name="model"></param>
        /// <param name="foreignKeyProperty"></param>
        /// <param name="foreignKeyValue"></param>
        public CreateCommand(TRequestModel model, string foreignKeyProperty, string foreignKeyValue)
        {
            this.Model = model;
            this.ForeignKeyProperty = foreignKeyProperty;
            this.ForeignKeyValue = foreignKeyValue;
        }

        /// <inheritdoc/>
        public TRequestModel Model { get; set; }
    }
}
