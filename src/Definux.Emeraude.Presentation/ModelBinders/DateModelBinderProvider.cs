using System;
using System.Linq;
using Definux.Emeraude.Application.Models;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Definux.Emeraude.Presentation.ModelBinders
{
    /// <summary>
    /// Customized <see cref="DateModel"/> model binder provider for the needs of Emeraude.
    /// </summary>
    public class DateModelBinderProvider : IModelBinderProvider
    {
        /// <inheritdoc/>
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            var allowedModelTypes = new[]
            {
                typeof(DateModel),
                typeof(DateModel?),
            };

            if (context.Metadata.ModelType == typeof(DateModel))
            {
                return new DateModelBinder();
            }

            if (allowedModelTypes.Contains(context.Metadata.ModelType))
            {
                return new DateModelBinder()
                {
                    AllowNullValue = context.Metadata.ModelType == typeof(DateModel?),
                };
            }

            return null;
        }
    }
}
