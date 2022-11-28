using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Essentials.Extensions;

namespace EmPages.Pages;

/// <summary>
/// Requirements for model supported by the framework.
/// </summary>
public static class EmPageValidators
{
    /// <summary>
    /// Checks whether the specified type is supported by the framework.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static bool IsTypeSupported(Type type)
    {
        var supportedPrimitiveTypes = EmPageStaticData.SupportedPrimitivesTypes.ToList();
        var isEnumerableType = type.IsEnumerableType();
        var isGenericType = type.IsConstructedGenericType;
        if (isEnumerableType && isGenericType && type.GetGenericArguments().First().IsEnum)
        {
            supportedPrimitiveTypes.Add(type.GetGenericArguments().First());
        }

        var underlyingType = type.GetTypeByIgnoreTheNullable();
        if (underlyingType.IsEnum)
        {
            return true;
        }

        foreach (var supportedType in EmPageStaticData.SupportedPrimitivesTypes)
        {
            if (supportedType == type)
            {
                return true;
            }
        }

        foreach (var supportedType in EmPageStaticData.SupportedNullablePrimitivesTypes)
        {
            if (supportedType == type)
            {
                return true;
            }
        }

        if (isGenericType)
        {
            foreach (var supportedBaseGenericType in EmPageStaticData.SupportedBaseGenericTypes)
            {
                foreach (var supportedPrimitiveType in supportedPrimitiveTypes)
                {
                    if (supportedBaseGenericType.MakeGenericType(supportedPrimitiveType).FullName == type.FullName)
                    {
                        return true;
                    }
                }
            }
        }

        return false;
    }

    /// <summary>
    /// Validates whether a specified model type is valid due the framework requirements.
    /// </summary>
    /// <param name="modelType"></param>
    public static void ValidateModelType(Type modelType)
    {
        if (!modelType.HasInterface<IEmPageModel>())
        {
            throw new EmSetupException($"Error during validation of '{modelType.FullName}'. Model must implements IEmPageModel interface.");
        }

        var publicModelProperties = EmPageUtilities.GetEmPageModelProperties(modelType);
        var incorrectProperties = new List<string>();
        foreach (var publicProperty in publicModelProperties)
        {
            if (!IsTypeSupported(publicProperty.PropertyType))
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