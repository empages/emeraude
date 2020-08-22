using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.Form
{
    public interface ICreateEditEntityViewModel
    {
        List<CreateEditInputViewModel> Inputs { get; set; }
    }
}
