using System;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Definux.Emeraude.ModelBinders
{
    /// <summary>
    /// Customized <see cref="DateTime"/> model binder provider for the needs of Emeraude.
    /// </summary>
    public class DateTimeModelBinderProvider : IModelBinderProvider
    {
        /// <inheritdoc/>
        public IModelBinder GetBinder(ModelBinderProviderContext context)
        {
            if (context == null)
            {
                throw new ArgumentNullException(nameof(context));
            }

            if (context.Metadata.ModelType == typeof(DateTime) ||
                context.Metadata.ModelType == typeof(DateTime?))
            {
                return new DateTimeModelBinder();
            }

            return null;
        }
    }
}
