using System;
using System.Linq;
using System.Net.Http;
using Emeraude.Application.Admin.EmPages.Schema;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Application.Admin.EmPages.Utilities;
using Emeraude.Defaults.Options;
using Emeraude.Essentials.Extensions;

namespace Emeraude.Defaults.Extensions;

/// <summary>
/// Extensions for <see cref="EmPageSchemaSettings{TModel}"/>.
/// </summary>
public static class EmPageSchemaSettingsExtensions
{
    /// <summary>
    /// Set defaults actions of the current schema. It must be executed as a last method of the schema because it is
    /// using the already defined setup.
    /// </summary>
    /// <param name="settings"></param>
    /// <typeparam name="TModel">EmPage model type.</typeparam>
    /// <returns></returns>
    public static EmPageSchemaSettings<TModel> ApplyDefaultEmPageActions<TModel>(this EmPageSchemaSettings<TModel> settings)
        where TModel : class, IEmPageModel, new()
    {
        settings.ModelActions.Add(new EmPageAction()
        {
            Order = 0,
            Name = "Details",
            RelativeUrlFormat = $"/{EmPagesPlaceholders.GetModelPlaceholder<TModel>(settings.Route, x => x.Id)}",
        });

        settings.ModelActions.Add(new EmPageAction()
        {
            Order = 10,
            Name = "Edit",
            RelativeUrlFormat = $"/{EmPagesPlaceholders.GetModelPlaceholder<TModel>(settings.Route, x => x.Id)}/edit",
        });

        settings.ModelActions.Add(new EmPageAction()
        {
            Order = 20,
            Name = "Delete",
            RelativeUrl = $"/_em/api/admin/em-pages/delete/{settings.Route}/{EmPagesPlaceholders.GetModelPlaceholder<TModel>(settings.Route, x => x.Id)}",
            Method = HttpMethod.Delete,
            ConfirmationMessage = "Are you sure you want to delete this entity?",
        });

        if (settings.FormViewConfigurationBuilder.ViewItems.Any(x => x.Type == FormViewItemType.CreateEdit || x.Type == FormViewItemType.EditOnly))
        {
            settings.DetailsViewConfigurationBuilder.PageActions.Add(new EmPageAction
            {
                Order = 1,
                Name = "Edit",
                RelativeUrlFormat = $"/{EmPagesPlaceholders.GetModelPlaceholder<TModel>(settings.Route, x => x.Id)}/edit",
            });
        }

        return settings;
    }
}