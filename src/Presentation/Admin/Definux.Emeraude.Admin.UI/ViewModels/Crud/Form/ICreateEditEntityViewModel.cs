using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Crud.Form
{
    public interface ICreateEditEntityViewModel
    {
        List<CreateEditInputViewModel> Inputs { get; set; }
    }
}
