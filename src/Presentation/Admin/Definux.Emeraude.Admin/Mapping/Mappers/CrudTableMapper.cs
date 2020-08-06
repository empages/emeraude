using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.UI.UIElements.Table;
using Definux.Emeraude.Admin.UI.ViewModels.Crud.Table;
using Definux.Emeraude.Admin.Utilities;
using Definux.Utilities.Extensions;
using Definux.Utilities.Objects;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.CrudMappers
{
    public static class CrudTableMapper
    {
        public static TableViewModel Map<T>(PaginatedList<T> entitiesResult, params TableRowActionViewModel[] actions)
        {
            Type dtoType = typeof(T);
            TableViewModel tableViewModel = new TableViewModel();
            var properties = dtoType.GetProperties();
            List<TableColumnAttribute> dtoAttributes = new List<TableColumnAttribute>();
            foreach (var property in properties)
            {
                if (property.HasAttribute<TableColumnAttribute>())
                {
                    dtoAttributes.Add((TableColumnAttribute)property.GetCustomAttributes(typeof(TableColumnAttribute), false).FirstOrDefault());
                }
            }

            List<string> tableHeaders = dtoAttributes.OrderBy(x => x.Order).Select(x => x.Name).Distinct().ToList();
            tableHeaders.ForEach(x => { tableViewModel.Header.AddCell(x); });

            if (entitiesResult.ItemsCount > 0)
            {
                foreach (var entity in entitiesResult.Items)
                {
                    TableRowViewModel tableRow = new TableRowViewModel();
                    foreach (var property in properties)
                    {
                        if (property.GetCustomAttributes(typeof(EntityIdentifierAttribute), false).Length > 0)
                        {
                            tableRow.Identifier = property.GetValue(entity)?.ToString();
                        }

                        if (property.HasAttribute<TableColumnAttribute>())
                        {
                            TableColumnAttribute propertyAttribute = (TableColumnAttribute)property.GetCustomAttributes(typeof(TableColumnAttribute), false).FirstOrDefault();
                            tableRow.AddCell(
                                propertyAttribute.Order,
                                property.GetValue(entity),
                                (ITableElement)Activator.CreateInstance(propertyAttribute.UIElementType));
                        }
                    }

                    foreach (var action in actions)
                    {
                        List<string> parsedParameters = new List<string>();
                        foreach (var parameter in action.RawParameters)
                        {
                            if (parameter.StartsWith("[", StringComparison.OrdinalIgnoreCase) && parameter.EndsWith("]", StringComparison.OrdinalIgnoreCase))
                            {
                                string propertyName = parameter.Substring(1, parameter.Length - 2);
                                string propertyValue = entity.GetType().GetProperty(propertyName)?.GetValue(entity).ToString();
                                parsedParameters.Add(propertyValue);
                            }
                            else
                            {
                                parsedParameters.Add(parameter);
                            }
                        }

                        tableRow.AddAction(action, parsedParameters);
                    }

                    tableViewModel.AddRow(tableRow);
                }
            }

            tableViewModel.SetPagination(entitiesResult.CurrentPage, entitiesResult.PagesCount);

            return tableViewModel;
        }

        /// <summary>
        /// Create table view item action.
        /// </summary>
        /// <param name="icon">https://cdn.materialdesignicons.com/4.9.95/</param>
        /// <param name="urlStringFormat"></param>
        /// <param name="parameters"></param>
        public static TableRowActionViewModel CreateAction(string title, string icon, TableRowActionMethod method, string urlStringFormat, params object[] parameters)
        {
            return new TableRowActionViewModel(title, icon, urlStringFormat, parameters.Select(x => x.ToString()).ToList(), method);
        }

        public static TableRowActionViewModel DetailsAction(string urlStringFormat, params object[] parameters)
        {
            return CreateAction("Details", MaterialDesignIcons.CardBulleted, TableRowActionMethod.Get, urlStringFormat, parameters);
        }

        public static TableRowActionViewModel EditAction(string urlStringFormat, params object[] parameters)
        {
            return CreateAction("Edit", MaterialDesignIcons.Pencil, TableRowActionMethod.Get, urlStringFormat, parameters);
        }

        public static TableRowActionViewModel DeleteAction(string urlStringFormat, params object[] parameters)
        {
            var action = CreateAction("Delete", MaterialDesignIcons.Delete, TableRowActionMethod.Post, urlStringFormat, parameters);
            action.SetConfirmation("Delete Entity", "Are you sure you want to delete this entity?");

            return action;
        }
    }
}
