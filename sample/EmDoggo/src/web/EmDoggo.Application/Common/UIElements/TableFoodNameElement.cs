using Definux.Emeraude.Admin.UI.UIElements;
using Definux.Emeraude.Admin.UI.UIElements.Table;
using Definux.HtmlBuilder;
using EmDoggo.Application.Common.Interfaces.Persistance;
using System;
using System.Linq;

namespace EmDoggo.Application.Common.UIElements
{
    public class TableFoodNameElement : UITextElement, ITableElement
    {
        public TableFoodNameElement()
            : base()
        {

        }

        public override void DefineHtmlBuilder()
        {
            var entityContext = (IEntityContext)ServiceProvider.GetService(typeof(IEntityContext));
            var foodId = Guid.Parse(DataSource.ToString());
            var food = entityContext.Foods.FirstOrDefault(x => x.Id == foodId);

            HtmlBuilder.StartElement(HtmlTags.Span)
                .Append($"{food?.Name} ({food.Manufacturer.ToString()})");
        }
    }
}
