using System;
using System.Threading.Tasks;
using Emeraude.Application.Models;
using Emeraude.Essentials.Base;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Emeraude.Presentation.ModelBinders
{
    /// <summary>
    /// Customized <see cref="DateModel"/> model binder for the needs of Emeraude.
    /// </summary>
    public class DateModelBinder : IModelBinder
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

            if (DateModel.TryParse(valueProviderResult.FirstValue, out var dateModel))
            {
                bindingContext.Result = ModelBindingResult.Success(dateModel);
                return Task.CompletedTask;
            }

            bindingContext.ModelState.TryAddModelError(bindingContext.ModelName, $"Incorrect DateModel format. Use following format in the request '{DateModel.DateModelFormat}'");
            return Task.CompletedTask;
        }
    }
}
