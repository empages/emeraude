using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System;
using System.Globalization;
using System.Threading.Tasks;

namespace Definux.Emeraude.ModelBinders
{
    public class DateTimeModelBinder : IModelBinder
    {
        public Task BindModelAsync(ModelBindingContext bindingContext)
        {
            if (bindingContext == null)
            {
                throw new ArgumentNullException(nameof(bindingContext));
            }

            var modelName = bindingContext.ModelName;
            var valueProviderResult = bindingContext.ValueProvider.GetValue(modelName);
            if (valueProviderResult == ValueProviderResult.None)
            {
                return Task.CompletedTask;
            }

            bindingContext.ModelState.SetModelValue(modelName, valueProviderResult);

            bool unixTimeStampFormat = double.TryParse(valueProviderResult.FirstValue, out double unixTimeStamp);
            CultureInfo enUS = new CultureInfo("en-US");
            bool standardFormat = DateTime.TryParseExact(valueProviderResult.FirstValue, SystemFormats.ShortDateFormat, enUS, DateTimeStyles.None, out DateTime parsedDateTime);

            if (unixTimeStampFormat)
            {
                DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime date = start.AddSeconds(unixTimeStamp).ToLocalTime();
                bindingContext.Result = ModelBindingResult.Success(date);
                return Task.CompletedTask;
            }
            else if (standardFormat)
            {
                bindingContext.Result = ModelBindingResult.Success(parsedDateTime);
                return Task.CompletedTask;
            }
            else
            {
                bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, $"Incorrect DateTime format. Use Unix Timestamp or {SystemFormats.ShortDateFormat}");
                return Task.CompletedTask;
            }
        }
    }
}
