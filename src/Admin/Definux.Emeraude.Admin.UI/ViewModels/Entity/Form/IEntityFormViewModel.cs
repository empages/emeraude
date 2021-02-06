using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Form
{
    /// <summary>
    /// Defines base structure of entity form view model.
    /// </summary>
    public interface IEntityFormViewModel
    {
        /// <summary>
        /// List of all inputs for the current form view model.
        /// </summary>
        List<FormInputViewModel> Inputs { get; set; }
    }
}
