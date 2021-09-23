using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.Models;
using Definux.Emeraude.Admin.Services;
using Definux.Emeraude.Admin.UI.Adapters;
using Definux.Emeraude.Admin.UI.Models;
using Definux.Emeraude.Admin.Utilities;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Extensions;
using Definux.Emeraude.Configuration.Options;
using Definux.Utilities.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Definux.Emeraude.Admin.Adapters
{
    /// <inheritdoc cref="IEntityAdminServiceAgent" />
    public class EntityAdminServiceAgent : AdminServiceAgent, IEntityAdminServiceAgent
    {
        private readonly EmMainOptions mainOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EntityAdminServiceAgent"/> class.
        /// </summary>
        /// <param name="httpClientFactory"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="optionsProvider"></param>
        /// <param name="logger"></param>
        public EntityAdminServiceAgent(
            IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IEmOptionsProvider optionsProvider,
            IEmLogger logger)
            : base(httpClientFactory, httpContextAccessor, optionsProvider, logger)
        {
            this.mainOptions = optionsProvider.GetMainOptions();
        }

        /// <inheritdoc/>
        public async Task<EntityTableViewData> RetrieveTableViewDataAsync(string entityKey, string queryString, EntityTableViewSchema schema)
        {
            var emptyResult = new EntityTableViewData();
            var entityDataControllerType = this.GetEntityDataController(entityKey);
            if (entityDataControllerType != null)
            {
                var controllerRoute = this.GetControllerRoute(entityDataControllerType, string.Empty);

                var requestResult = await this.GetAsync<TableViewDataRequestResult>(controllerRoute + queryString);
                if (requestResult != null)
                {
                    var result = new EntityTableViewData();
                    foreach (var item in requestResult.Items)
                    {
                        var rowModel = new EntityTableRowModel
                        {
                            Identifier = item
                                .Fields
                                .Where(x => x.Property == "Id")
                                .Select(x => x.Value)
                                .FirstOrDefault()
                                ?.ToString(),
                        };

                        int fieldIndex = 0;
                        foreach (var field in item.Fields)
                        {
                            if (schema.PropertyComponentPair.ContainsKey(field.Property))
                            {
                                rowModel.Cells.Add(new EntityTableCellModel
                                {
                                    Order = fieldIndex,
                                    Value = field.Value,
                                    Property = field.Property,
                                    Type = schema.PropertyTypePair[field.Property],
                                    Component = schema.PropertyComponentPair[field.Property],
                                });

                                fieldIndex++;
                            }
                        }

                        foreach (var action in schema.RowActions)
                        {
                            rowModel.Actions.Add(new ActionModel
                            {
                                Title = action.Title,
                                Order = action.Order,
                                ActionUrl = string.Format(action.ActionUrl, rowModel.Identifier),
                                ActionHttpMethod = action.ActionHttpMethod,
                                OpenOnSeparatePage = action.OpenOnSeparatePage,
                                ConfirmationMessage = action.ConfirmationMessage,
                            });
                        }

                        result.Rows.Add(rowModel);
                    }

                    result.PaginationModel = new PaginationModel(requestResult.CurrentPage, requestResult.PagesCount);

                    return result;
                }
            }

            return emptyResult;
        }

        private Type GetEntityDataController(string entityKey)
        {
            var controllerTypes = AssemblyHelpers
                    .GetClassesThatImplements<IAdminEntityDataController>(this.mainOptions.Assemblies)
                    .Where(x => !x.IsAbstract && x.BaseType != null);

            Type targetControllerType = null;
            foreach (var controllerType in controllerTypes)
            {
                try
                {
                    var modelType = controllerType.BaseType?.GetGenericArguments().ElementAt(1);
                    var modelTempInstance = Activator.CreateInstance(modelType) as IEntityAdminSchemaModel;
                    var modelEntityKey = modelTempInstance?.Setup().Key;
                    if (entityKey.Equals(modelEntityKey, StringComparison.OrdinalIgnoreCase))
                    {
                        targetControllerType = controllerType;
                        break;
                    }
                }
                catch (Exception)
                {
                    // ignored
                }
            }

            return targetControllerType;
        }

        private string GetControllerRoute(Type controllerType, string route)
        {
            var routeAttribute = controllerType
                .BaseType
                .GetAttribute<RouteAttribute>();

            string baseRoute = routeAttribute
                .Template
                .Replace("[controller]", controllerType.Name.Replace("Controller", string.Empty));

            if (!baseRoute.EndsWith("/"))
            {
                baseRoute = $"{baseRoute}/";
            }

            var resultRoute = route.StartsWith("/") ? $"{baseRoute}{route.Substring(1)}" : $"{baseRoute}{route}";

            return resultRoute;
        }
    }
}