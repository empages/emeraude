using Definux.Emeraude.Domain.Entities;
using MediatR;
using System;

namespace Definux.Emeraude.Admin.Requests.Details
{
    public interface IDetailsQuery<TEntity, TRequestModel> : IRequest<TRequestModel>
        where TEntity : class, IEntity, new()
        where TRequestModel : class, new()
    {
        Guid EntityId { get; set; }

        string ForeignKeyProperty { get; set; }

        string ForeignKeyValue { get; set; }
    }
}
