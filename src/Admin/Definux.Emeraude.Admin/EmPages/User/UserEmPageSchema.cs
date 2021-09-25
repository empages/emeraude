using System.Threading.Tasks;
using Definux.Emeraude.Admin.UI.Components.Base;

namespace Definux.Emeraude.Admin.EmPages.User
{
    /// <summary>
    /// EmPage user schema.
    /// </summary>
    public class UserEmPageSchema : IEmPageSchema<UserEmPageModel>
    {
        /// <inheritdoc/>
        public async Task<EmPageSchemaSettings<UserEmPageModel>> SetupAsync(EmPageSchemaContext context)
        {
            var settings = new EmPageSchemaSettings<UserEmPageModel>
            {
                Key = "users",
                Title = "Users",
            };

            settings
                .ConfigureTableView(tableView =>
                {
                    tableView
                        .Use(x => x.Email, item =>
                        {
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.Name, item =>
                        {
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.RegistrationDate, item =>
                        {
                            item.Title = "Registration";
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.TwoFactorEnabled, item =>
                        {
                            item.Title = "2FA";
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.IsLockedOut, item =>
                        {
                            item.Title = "Locked Out";
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.EmailConfirmed, item =>
                        {
                            item.SetComponent<EmText>();
                        });
                })
                .ConfigureDetailsView(detailsView =>
                {
                    detailsView
                        .Use(x => x.Id, item =>
                        {
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.Email, item =>
                        {
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.Name, item =>
                        {
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.RegistrationDate, item =>
                        {
                            item.Title = "Registration";
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.TwoFactorEnabled, item =>
                        {
                            item.Title = "2FA";
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.IsLockedOut, item =>
                        {
                            item.Title = "Locked Out";
                            item.SetComponent<EmText>();
                        })
                        .Use(x => x.EmailConfirmed, item =>
                        {
                            item.SetComponent<EmText>();
                        });
                });

            return settings;
        }
    }
}