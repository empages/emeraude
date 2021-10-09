using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Admin.EmPages.UI.Components.Base;
using FluentValidation;

namespace Definux.Emeraude.Admin.EmPages.User
{
    /// <summary>
    /// EmPage user schema.
    /// </summary>
    public class UserEmPageSchema : IEmPageSchema<Identity.Entities.User, UserEmPageModel>
    {
        /// <inheritdoc/>
        public async Task<EmPageSchemaSettings<Identity.Entities.User, UserEmPageModel>> SetupAsync()
        {
            var settings = new EmPageSchemaSettings<Identity.Entities.User, UserEmPageModel>
            {
                Key = "users",
                Title = "Users",
            };

            settings
                .ConfigureTableView(tableView =>
                {
                    tableView.PageActions.Clear();

                    tableView
                        .Use(x => x.Email, item =>
                        {
                            item.SetComponent<EmPageText>();
                        })
                        .Use(x => x.Name, item =>
                        {
                            item.SetComponent<EmPageText>();
                        })
                        .Use(x => x.RegistrationDate, item =>
                        {
                            item.Title = "Registration";
                            item.SetComponent<EmPageText>();
                        })
                        .Use(x => x.TwoFactorEnabled, item =>
                        {
                            item.Title = "2FA";
                            item.SetComponent<EmPageFlag>();
                        })
                        .Use(x => x.IsLockedOut, item =>
                        {
                            item.Title = "Locked Out";
                            item.SetComponent<EmPageFlag>();
                        })
                        .Use(x => x.EmailConfirmed, item =>
                        {
                            item.SetComponent<EmPageFlag>();
                        });
                })
                .ConfigureDetailsView(detailsView =>
                {
                    detailsView
                        .Use(x => x.Id, item =>
                        {
                            item.SetComponent<EmPageText>();
                        })
                        .Use(x => x.Email, item =>
                        {
                            item.SetComponent<EmPageText>();
                        })
                        .Use(x => x.Name, item =>
                        {
                            item.SetComponent<EmPageText>();
                        })
                        .Use(x => x.RegistrationDate, item =>
                        {
                            item.Title = "Registration";
                            item.SetComponent<EmPageText>();
                        })
                        .Use(x => x.TwoFactorEnabled, item =>
                        {
                            item.Title = "2FA";
                            item.SetComponent<EmPageFlag>();
                        })
                        .Use(x => x.IsLockedOut, item =>
                        {
                            item.Title = "Locked Out";
                            item.SetComponent<EmPageFlag>();
                        })
                        .Use(x => x.EmailConfirmed, item =>
                        {
                            item.SetComponent<EmPageFlag>();
                        });
                })
                .BuildDefaults();

            settings.ModelActions.RemoveAt(1);

            return settings;
        }
    }
}