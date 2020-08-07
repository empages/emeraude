using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Form;
using Definux.Emeraude.Admin.UI.ViewModels.Crud.Form;
using Definux.Utilities.Extensions;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.Mapping.Mappers
{
    public static class CrudFormMapper
    {
        public static List<CreateEditInputViewModel> BuildInputs(ICreateEditEntityViewModel entityViewModel)
        {
            var resultList = new List<CreateEditInputViewModel>();
            Type modelType = entityViewModel.GetType();
            var modelProperties = modelType.GetProperties();
            foreach (var property in modelProperties)
            {
                if (property.HasAttribute<FormInputAttribute>())
                {
                    FormInputAttribute propertyAttribute = property.GetAttribute<FormInputAttribute>();
                    var inputViewModel = new CreateEditInputViewModel
                    {
                        Label = propertyAttribute.Name,
                        Name = property.Name,
                        FormElement = (IFormElement)Activator.CreateInstance(propertyAttribute.UIElementType),
                        DataSourceType = property.PropertyType,
                        Value = property.GetValue(entityViewModel),
                        Order = propertyAttribute.Order,
                    };

                    if (inputViewModel.DataSourceType == null && property.PropertyType.IsArray && property.PropertyType.GetElementType().IsEnum)
                    {
                        inputViewModel.DataSourceType = property.PropertyType.GetElementType();
                    }

                    if (inputViewModel.DataSourceType == null && property.PropertyType.GetInterface(nameof(IEnumerable)) != null && (property.PropertyType.GetGenericArguments().FirstOrDefault()?.IsEnum ?? false))
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
