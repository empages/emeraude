using Definux.Emeraude.Domain.Entities;

namespace Definux.Emeraude.Admin.Requests.GetAll
{
    public class GetAllQuery<TEntity, TRequestModel> : IGetAllQuery<TEntity, TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        public GetAllQuery(int page, string searchQuery)
        {
            Page = page;
            SearchQuery = searchQuery;
        }

        public GetAllQuery(int page, string searchQuery, string foreignKeyProperty, string foreignKeyValue)
        {
            Page = page;
            SearchQuery = searchQuery;
            ForeignKeyProperty = foreignKeyProperty;
            ForeignKeyValue = foreignKeyValue;
        }

        public int Page { get; set; }

        public int PageSize { get; set; } = 25;

        public string SearchQuery { get; set; }

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
