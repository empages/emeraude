using System.Linq;
using Definux.Emeraude.Admin.UI.UIElements;
using EmDoggo.Application.Interfaces;

namespace EmDoggo.Application.CustomEntityDataPairs
{
    public class FoodCustomEntityDataPair : CustomEntityDataPair<IEntityContext>
    {
        public FoodCustomEntityDataPair(IEntityContext context)
            : base(context)
        {
        }

        protected override void LoadData()
        {
            var foods = this.Context.Foods.ToList();
            foreach (var food in foods)
            {
                this[food.Id] = food.Name;
            }
        }
    }
}