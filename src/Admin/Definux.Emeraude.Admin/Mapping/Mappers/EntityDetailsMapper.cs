using System;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Details;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Details;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard;
using Definux.Utilities.Extensions;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.Mapping.Mappers
{
    /// <summary>
    /// Static mapper that convert entities in the details card format.
    /// </summary>
    public static class EntityDetailsMapper
    {
        /// <summary>
        /// Map entities to <see cref="DetailsViewModel"/> by using the decorated properties of the view model entity implementation by <seealso cref="DetailsFieldAttribute"/>.
        /// </summary>
        /// <typeparam name="T">ViewModel entity implementation.</typeparam>
        /// <param name="entity"></param>
        /// <returns></returns>
        public static DetailsViewModel Map<T>(T entity)
        {
            Type dtoType = typeof(T);
            DetailsViewModel detailsViewModel = new DetailsViewModel();
            var properties = dtoType.GetProperties();
            foreach (var property in properties)
            {
                if (property.HasAttribute<DetailsFieldAttribute>())
                {
                    var attribute = property.GetAttribute<DetailsFieldAttribute>();
                    int order = attribute.Order;
                    DetailsPropertyViewModel detailsProperty = new DetailsPropertyViewModel();
                    detailsProperty.Name = string.IsNullOrEmpty(attribute.Title) ? StringFunctions.SplitWordsByCapitalLetters(property.Name) : attribute.Title;
                    detailsProperty.Value = property.GetValue(entity);
                    detailsProperty.DetailsFieldElement = (IDetailsFieldElement)Activator.CreateInstance(attribute.UIElementType);
                    detailsProperty.Order = order;
                    detailsViewModel.AddProperty(detailsProperty);
                }
            }

            return detailsViewModel;
        }
    }
}
