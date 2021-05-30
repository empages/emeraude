using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Definux.Emeraude.Presentation.ModelBinders
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

            var allowedDateTimeModelTypes = new[]
            {
                typeof(DateTime),
                typeof(DateTime?),
            };

            var allowedDateTimeOffsetModelTypes = new[]
            {
                typeof(DateTimeOffset),
                typeof(DateTimeOffset?),
            };

            if (allowedDateTimeModelTypes.Contains(context.Metadata.ModelType))
            {
                return new DateTimeModelBinder<DateTime>
                {
                    AllowNullValue = context.Metadata.ModelType == typeof(DateTime?),
                };
            }

            if (allowedDateTimeOffsetModelTypes.Contains(context.Metadata.ModelType))
            {
                return new DateTimeModelBinder<DateTimeOffset>()
                {
                    AllowNullValue = context.Metadata.ModelType == typeof(DateTimeOffset?),
                };
            }

            return null;
        }
    }
}
