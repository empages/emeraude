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

            settings.UseDefaults();
            settings.ModelActions.RemoveAt(1);

            settings
                .ConfigureTableView(tableView =>
                {
                    tableView.PageActions.Clear();

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
                            item.SetComponent<EmFlag>();
                        })
                        .Use(x => x.IsLockedOut, item =>
                        {
                            item.Title = "Locked Out";
                            item.SetComponent<EmFlag>();
                        })
                        .Use(x => x.EmailConfirmed, item =>
                        {
                            item.SetComponent<EmFlag>();
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
                            item.SetComponent<EmFlag>();
                        })
                        .Use(x => x.IsLockedOut, item =>
                        {
                            item.Title = "Locked Out";
                            item.SetComponent<EmFlag>();
                        })
                        .Use(x => x.EmailConfirmed, item =>
                        {
                            item.SetComponent<EmFlag>();
                        });
                })
                .ConfigureFormView(x =>
                {
                    x.ConfigureCreateCommandValidator(validator =>
                    {
                        validator.RuleFor(y => y.Model.Email)
                            .Must(y => y.Contains("asd"))
                            .WithMessage("nanana");
                    });

                    x.ConfigureEditCommandValidator(validator =>
                    {
                        validator.RuleFor(y => y.Model.Email)
                            .Must(y => y.Contains("asd"))
                            .WithMessage("nanana");
                    });
                });

            return settings;
        }
    }
}