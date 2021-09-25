using System;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Attributes;
using Definux.Emeraude.Admin.Controllers.Abstractions;
using Definux.Emeraude.Admin.EmPages;
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
    /// <inheritdoc cref="IEmPageServiceAgent" />
    public class EmPageServiceAgent : AdminServiceAgent, IEmPageServiceAgent
    {
        private readonly IEmPageService emPageService;
        private readonly EmMainOptions mainOptions;

        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageServiceAgent"/> class.
        /// </summary>
        /// <param name="httpClientFactory"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="optionsProvider"></param>
        /// <param name="emPageService"></param>
        /// <param name="logger"></param>
        public EmPageServiceAgent(
            IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IEmOptionsProvider optionsProvider,
            IEmPageService emPageService,
            IEmLogger logger)
            : base(httpClientFactory, httpContextAccessor, optionsProvider, logger)
        {
            this.emPageService = emPageService;
            this.mainOptions = optionsProvider.GetMainOptions();
        }

        /// <inheritdoc/>
        public async Task<EmPageTableViewData> RetrieveTableViewDataAsync(string entityKey, string queryString, EmPageTableViewSchema schema)
        {
            var emptyResult = new EmPageTableViewData();
            var entityDataControllerType = await this.GetEntityDataControllerAsync(entityKey);
            if (entityDataControllerType != null)
            {
                var controllerRoute = this.GetControllerRoute(entityDataControllerType, string.Empty);

                var requestResult = await this.GetAsync<TableViewDataRequestResult>(controllerRoute + queryString);
                if (requestResult != null)
                {
                    var result = new EmPageTableViewData();
                    foreach (var item in requestResult.Items)
                    {
                        var rowModel = new EmPageTableRowModel
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
                                rowModel.Cells.Add(new EmPageTableCellModel
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

        private async Task<Type> GetEntityDataControllerAsync(string entityKey)
        {
            var schemaDescription = await this.emPageService.FindSchemaDescriptionAsync(entityKey);
            return schemaDescription.DataControllerType;
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