using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Form
{
    /// <summary>
    /// Implementation of entity form view model.
    /// </summary>
    public abstract class EntityFormViewModel : IEntityFormViewModel
    {
        /// <summary>
        /// Name of the target entity for the view model.
        /// </summary>
        public string EntityName { get; set; }

        /// <summary>
        /// Name of the area of action which are using the view model.
        /// </summary>
        public string Area { get; set; }

        /// <summary>
        /// Name of the controller of action which are using the view model.
        /// </summary>
        public string Controller { get; set; }

        /// <summary>
        /// Name of the action which are using the view model.
        /// </summary>
        public string Action { get; set; }

        /// <summary>
        /// <inheritdoc />
        /// </summary>
        public List<FormInputViewModel> Inputs { get; set; }
    }
}
