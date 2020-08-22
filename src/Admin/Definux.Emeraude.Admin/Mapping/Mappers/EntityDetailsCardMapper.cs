using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.DetailsCard;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard;
using Definux.Utilities.Extensions;
using Definux.Utilities.Functions;
using System;

namespace Definux.Emeraude.Admin.Mapping.Mappers
{
    public static class EntityDetailsCardMapper
    {
        public static DetailsViewModel Map<T>(T entity)
        {
            Type dtoType = typeof(T);
            DetailsViewModel detailsViewModel = new DetailsViewModel();
            var properties = dtoType.GetProperties();
            foreach (var property in properties)
            {
                if (property.HasAttribute<DetailsCardAttribute>())
                {
                    var attribute = property.GetAttribute<DetailsCardAttribute>();
                    int order = attribute.Order;
                    DetailsPropertyViewModel detailsProperty = new DetailsPropertyViewModel();
                    detailsProperty.Name = string.IsNullOrEmpty(attribute.Title) ? StringFunctions.SplitWordsByCapitalLetters(property.Name) : attribute.Title;
                    detailsProperty.Value = property.GetValue(entity);
                    detailsProperty.DetailsCardElement = (IDetailsCardElement)Activator.CreateInstance(attribute.UIElementType);
                    detailsProperty.Order = order;
                    detailsViewModel.AddProperty(detailsProperty);
                }
            }

            return detailsViewModel;
        }
    }
}
