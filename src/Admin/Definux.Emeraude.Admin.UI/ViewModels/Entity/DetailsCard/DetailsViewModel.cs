using System.Collections.Generic;
using System.Linq;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard
{
    public class DetailsViewModel
    {
        private List<DetailsPropertyViewModel> properties;

        public DetailsViewModel()
        {
            this.properties = new List<DetailsPropertyViewModel>();
        }

        public List<DetailsPropertyViewModel> Properties
        {
            get
            {
                return this.properties.OrderBy(x => x.Order).ToList();
            }
        }

        public void AddProperty(DetailsPropertyViewModel property)
        {
            this.properties.Add(property);
        }
    }
}
