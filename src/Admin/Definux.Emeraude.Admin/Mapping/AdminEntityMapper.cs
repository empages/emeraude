using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Details;
using Definux.Emeraude.Admin.UI.UIElements.Form;
using Definux.Emeraude.Admin.UI.UIElements.Table;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Details;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Form;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Table;
using Definux.Utilities.Extensions;
using Definux.Utilities.Functions;
using Definux.Utilities.Objects;

namespace Definux.Emeraude.Admin.Mapping
{
    /// <inheritdoc />
    public class AdminEntityMapper : IAdminEntityMapper
    {
        /// <inheritdoc />
        public TableViewModel MapToTableViewModel<T>(PaginatedList<T> entitiesResult, params TableRowActionViewModel[] actions)
        {
            Type modelType = typeof(T);
            TableViewModel tableViewModel = new TableViewModel();
            var properties = modelType.GetProperties();
            List<TableColumnAttribute> dtoAttributes = new List<TableColumnAttribute>();
            foreach (var property in properties)
            {
                if (property.HasAttribute<TableColumnAttribute>())
                {
                    dtoAttributes.Add(property.GetAttribute<TableColumnAttribute>());
                }
            }

            List<string> tableHeaders = dtoAttributes.OrderBy(x => x.Order).Select(x => x.Name).Distinct().ToList();
            tableHeaders.ForEach(x => { tableViewModel.Header.AddCell(x); });

            if (entitiesResult.ItemsCount > 0)
            {
                foreach (var entity in entitiesResult.Items)
                {
                    tableViewModel.AddRow(this.BuildTableRowViewModel(entity, properties, actions));
                }
            }

            tableViewModel.SetPagination(entitiesResult.CurrentPage, entitiesResult.PagesCount);

            return tableViewModel;
        }

        /// <inheritdoc />
        public DetailsViewModel MapToDetailsViewModel<T>(T entity)
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
                    DetailsPropertyViewModel detailsProperty = new DetailsPropertyViewModel
                    {
                        Name = string.IsNullOrEmpty(attribute.Title)
                            ? StringFunctions.SplitWordsByCapitalLetters(property.Name)
                            : attribute.Title,
                        Value = property.GetValue(entity),
                        DetailsFieldElement = (IDetailsFieldElement)Activator.CreateInstance(attribute.UIElementType),
                        Order = order,
                    };
                    detailsViewModel.AddProperty(detailsProperty);
                }
            }

            return detailsViewModel;
        }

        /// <inheritdoc />
        public List<FormInputViewModel> MapToFormInputViewModels(IEntityFormViewModel entityViewModel)
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

        private string GetParsedParameterValue<T>(string parameter, T entity)
        {
            string value;
            if (parameter.StartsWith("[", StringComparison.OrdinalIgnoreCase) && parameter.EndsWith("]", StringComparison.OrdinalIgnoreCase))
            {
                string propertyName = parameter.Substring(1, parameter.Length - 2);
                value = entity.GetType().GetProperty(propertyName)?.GetValue(entity)?.ToString();
            }
            else
            {
                value = parameter;
            }

            return value;
        }

        private TableRowViewModel BuildTableRowViewModel<T>(T entity, IEnumerable<PropertyInfo> properties, TableRowActionViewModel[] actions)
        {
            TableRowViewModel tableRow = new TableRowViewModel();
            foreach (var property in properties)
            {
                if (property.HasAttribute<EntityIdentifierAttribute>())
                {
                    tableRow.Identifier = property.GetValue(entity)?.ToString();
                }

                if (property.HasAttribute<TableColumnAttribute>())
                {
                    TableColumnAttribute propertyAttribute = (TableColumnAttribute)property.GetCustomAttributes(typeof(TableColumnAttribute), false).FirstOrDefault();

                    ITableElement tableElementInstance = (ITableElement)Activator.CreateInstance(propertyAttribute.UIElementType);

                    tableRow.AddCell(
                        propertyAttribute.Order,
                        property.GetValue(entity),
                        tableElementInstance);
                }
            }

            foreach (var action in actions)
            {
                List<string> parsedParameters = new List<string>();
                foreach (var parameter in action.RawParameters)
                {
                    parsedParameters.Add(this.GetParsedParameterValue(parameter, entity));
                }

                tableRow.AddAction(action, parsedParameters);
            }

            return tableRow;
        }
    }
}