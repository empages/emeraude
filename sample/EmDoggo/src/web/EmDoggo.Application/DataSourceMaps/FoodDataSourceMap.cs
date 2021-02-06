using System.Linq;
using Definux.Emeraude.Admin.UI.UIElements;
using EmDoggo.Application.Interfaces;

namespace EmDoggo.Application.DataSourceMaps
{
    public class FoodDataSourceMap : DataSourceMap<IEntityContext>
    {
        public FoodDataSourceMap(IEntityContext context)
            : base(context)
        {
        }

        protected override void Init()
        {
            var foods = this.Context.Foods.ToList();
            foreach (var food in foods)
            {
                this[food.Id] = food.Name;
            }
        }
    }
}