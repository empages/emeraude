using System.Collections.Generic;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Definux.Utilities.Objects;

namespace Definux.Emeraude.Admin.Mapping
{
    /// <summary>
    /// Mapper service that provides conversion service between admin view models and UI models.
    /// </summary>
    public interface IAdminEntityMapper
    {
        /// <summary>
        /// Map entities to <see cref="TableViewModel"/> by using the decorated properties of the view model entity implementation by <seealso cref="TableColumnAttribute"/>.
        /// </summary>
        /// <param name="entitiesResult"></param>
        /// <param name="actions"></param>
        /// <typeparam name="T">ViewModel entity implementation.</typeparam>
        /// <returns></returns>
        TableViewModel MapToTableViewModel<T>(PaginatedList<T> entitiesResult, params TableRowActionViewModel[] actions);

        /// <summary>
        /// Map entities to <see cref="DetailsViewModel"/> by using the decorated properties of the view model entity implementation by <seealso cref="DetailsFieldAttribute"/>.
        /// </summary>
        /// <typeparam name="T">ViewModel entity implementation.</typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        DetailsViewModel MapToDetailsViewModel<T>(T entity);

        /// <summary>
        /// Converts specified ViewModel (<see cref="IEntityFormViewModel"/>) to collection of <see cref="EntityFormViewModel"/> by using the decorated properties of the view model entity implementation by <seealso cref="FormInputAttribute"/>.
        /// </summary>
        /// <param name="entityViewModel"></param>
        /// <returns></returns>
        List<FormInputViewModel> MapToFormInputViewModels(IEntityFormViewModel entityViewModel);
    }
}