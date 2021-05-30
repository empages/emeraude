using System.Collections.Generic;
using System.Linq;
using Definux.Emeraude.Admin.UI.ViewModels.Entity.Details;

namespace Definux.Emeraude.Admin.UI.ViewModels.Entity.DetailsCard
{
    /// <summary>
    /// Implementation of the details card of the entity.
    /// </summary>
    public class DetailsViewModel
    {
        private List<DetailsPropertyViewModel> properties;

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsViewModel"/> class.
        /// </summary>
        public DetailsViewModel()
        {
            this.properties = new List<DetailsPropertyViewModel>();
        }

        /// <summary>
        /// List of all properties of the details card implemented by <see cref="DetailsPropertyViewModel"/>.
        /// </summary>
        public List<DetailsPropertyViewModel> Properties
        {
            get
            {
                return this.properties.OrderBy(x => x.Order).ToList();
            }
        }

        /// <summary>
        /// Add a property to the card details.
        /// </summary>
        /// <param name="property"></param>
        public void AddProperty(DetailsPropertyViewModel property)
        {
            this.properties.Add(property);
        }
    }
}
