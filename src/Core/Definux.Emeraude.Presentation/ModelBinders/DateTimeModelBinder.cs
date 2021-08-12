using System;
using System.Globalization;
using System.Threading.Tasks;
using Definux.Emeraude.Resources;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Definux.Emeraude.Presentation.ModelBinders
{
    /// <summary>
    /// Customized <see cref="DateTime"/> model binder for the needs of Emeraude.
    /// </summary>
    /// <typeparam name="TDateTime">DateTime or DateTimeOffset type.</typeparam>
    public class DateTimeModelBinder<TDateTime> : IModelBinder
    {
        /// <summary>
        /// Flag that indicates whether the model can be null.
        /// </summary>
        public bool AllowNullValue { get; set; }

        /// <inheritdoc/>
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

            if (this.AllowNullValue && string.IsNullOrEmpty(valueProviderResult.FirstValue))
            {
                bindingContext.Result = ModelBindingResult.Success(null);
                return Task.CompletedTask;
            }

            bool unixTimeStampFormat = double.TryParse(valueProviderResult.FirstValue, out double unixTimeStamp);
            CultureInfo enUs = new CultureInfo("en-US");
            bool standardFormat = DateTime.TryParseExact(valueProviderResult.FirstValue, SystemFormats.ShortDateFormat, enUs, DateTimeStyles.None, out DateTime parsedDateTime);

            if (unixTimeStampFormat)
            {
                DateTime start = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);
                DateTime date = start.AddSeconds(unixTimeStamp).ToUniversalTime();
                bindingContext.Result = ModelBindingResult.Success(this.GetDateTimeObject(date));
                return Task.CompletedTask;
            }

            if (standardFormat)
            {
                bindingContext.Result = ModelBindingResult.Success(parsedDateTime);
                return Task.CompletedTask;
            }

            bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, $"Incorrect DateTime format. Use Unix Timestamp or {SystemFormats.ShortDateFormat}");
            return Task.CompletedTask;
        }

        private object GetDateTimeObject(DateTime dateTime)
        {
            if (typeof(TDateTime) == typeof(DateTime))
            {
                return dateTime;
            }
            else if (typeof(TDateTime) == typeof(DateTimeOffset))
            {
                DateTimeOffset resultOffset = dateTime;
                return resultOffset;
            }

            return null;
        }
    }
}
