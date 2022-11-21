using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Essentials.Extensions;

namespace EmPages.Pages.StaticValidation;

/// <summary>
/// Requirements for model supported by the framework.
/// </summary>
internal static class ModelValidator
{
    /// <summary>
    /// Validates whether a specified model type is valid due the framework requirements.
    /// </summary>
    /// <param name="modelType"></param>
    internal static void ValidateModelType(Type modelType)
    {
        if (!modelType.HasInterface<IEmPageModel>())
        {
            throw new EmSetupException($"Error during validation of '{modelType.FullName}'. Model must implements IEmPageModel interface.");
        }

        var publicModelProperties = modelType.GetProperties(BindingFlags.Public | BindingFlags.Instance);
        var incorrectProperties = new List<string>();
        foreach (var publicProperty in publicModelProperties)
        {
            if (!TypeRequirements.IsTypeSupported(publicProperty.PropertyType))
            {
                incorrectProperties.Add(publicProperty.Name);
            }
        }

        if (incorrectProperties.Any())
        {
            throw new EmSetupException($"Error during validation of '{modelType.FullName}'. The following properties are with unsupported type: [{string.Join(", ", incorrectProperties)}]");
        }
    }
}