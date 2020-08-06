using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.ViewModels.Crud.Form
{
    public class CreateEditEntityViewModel : ICreateEditEntityViewModel
    {
        public string EntityName { get; set; }

        public string Area { get; set; }

        public string Controller { get; set; }

        public string Action { get; set; }

        public List<CreateEditInputViewModel> Inputs { get; set; }
    }
}
