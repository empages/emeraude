using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Form;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.Mapping.Mappers
{
    /// <summary>
    /// Static mapper that convert entities in the form format.
    /// </summary>
    public static class EntityFormMapper
    {
        /// <summary>
        /// Converts specified ViewModel (<see cref="IEntityFormViewModel"/>) to collection of <see cref="EntityFormViewModel"/> by using the decorated properties of the view model entity implementation by <seealso cref="FormInputAttribute"/>.
        /// </summary>
        /// <param name="entityViewModel"></param>
        /// <returns></returns>
        public static List<FormInputViewModel> BuildInputs(IEntityFormViewModel entityViewModel)
        {
            var resultList = new List<FormInputViewModel>();
            Type modelType = entityViewModel.GetType();
            var modelProperties = modelType.GetProperties();
            foreach (var property in modelProperties)
            {
                if (property.HasAttribute<FormInputAttribute>())
                {
                    FormInputAttribute propertyAttribute = property.GetAttribute<FormInputAttribute>();
                    var inputViewModel = new FormInputViewModel
                    {
                        Label = propertyAttribute.Name,
                        Name = property.Name,
                        FormElement = (IFormElement)Activator.CreateInstance(propertyAttribute.UIElementType),
                        DataSourceType = property.PropertyType,
                        Value = property.GetValue(entityViewModel),
                        Order = propertyAttribute.Order,
                    };

                    if (property.PropertyType.IsArray && property.PropertyType.GetElementType().IsEnum)
                    {
                        inputViewModel.DataSourceType = property.PropertyType.GetElementType();
                    }

                    if (property.PropertyType.GetInterface(nameof(IEnumerable)) != null && (property.PropertyType.GetGenericArguments().FirstOrDefault()?.IsEnum ?? false))
                    {
                        inputViewModel.DataSourceType = property.PropertyType.GetGenericArguments().FirstOrDefault();
                    }

                    if (propertyAttribute.DataSourceType != null)
                    {
                        inputViewModel.DataSourceType = propertyAttribute.DataSourceType;
                        inputViewModel.VisualizationPropertyName = propertyAttribute.VisualizationPropertyName;
                    }

                    resultList.Add(inputViewModel);
                }
            }

            return resultList.OrderBy(x => x.Order).ToList();
        }
    }
}
