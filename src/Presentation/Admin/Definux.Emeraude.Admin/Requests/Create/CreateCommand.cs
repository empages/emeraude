using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.Create
{
    public class CreateCommand<TEntity, TRequestModel> : ICreateCommand<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        public CreateCommand(TRequestModel model)
        {
            Model = model;
        }

        public CreateCommand(TRequestModel model, string foreignKeyProperty, string foreignKeyValue)
        {
            Model = model;
            ForeignKeyProperty = foreignKeyProperty;
            ForeignKeyValue = foreignKeyValue;
        }

        public TRequestModel Model { get; set; }

        public bool ValidateParent
        {
            get
            {
                return !string.IsNullOrWhiteSpace(ForeignKeyProperty) && !string.IsNullOrWhiteSpace(ForeignKeyValue);
            }
        }

        public string ForeignKeyProperty { get; set; }

        public string ForeignKeyValue { get; set; }
    }
}
