using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using Emeraude.Application.ClientBuilder.Attributes;
using Emeraude.Application.ClientBuilder.Models;
using Emeraude.Essentials.Extensions;

namespace Emeraude.Application.ClientBuilder.Services;

/// <summary>
/// Static class which provide methods for simplified type description extraction.
/// </summary>
public static class DescriptionExtractor
{
    private static readonly Dictionary<Type, string> PrimitiveTypes = new Dictionary<Type, string>
    {
        { typeof(bool), "bool" },
        { typeof(string), "string" },
        { typeof(char), "char" },
        { typeof(Guid), "Guid" },
        { typeof(DateTime), "DateTime" },
        { typeof(TimeSpan), "TimeSpan" },
        { typeof(byte), "byte" },
        { typeof(short), "short" },
        { typeof(int), "int" },
        { typeof(long), "long" },
        { typeof(sbyte), "sbyte" },
        { typeof(ushort), "ushort" },
        { typeof(uint), "uint" },
        { typeof(ulong), "ulong" },
        { typeof(float), "float" },
        { typeof(double), "double" },
        { typeof(decimal), "decimal" },
    };

    private static readonly Dictionary<Type, string> DefaultValues = new Dictionary<Type, string>
    {
        { typeof(bool), "false" },
        { typeof(string), "null" },
        { typeof(char), "null" },
        { typeof(Guid), "null" },
        { typeof(DateTime), "null" },
        { typeof(TimeSpan), "null" },
        { typeof(byte), "0" },
        { typeof(short), "0" },
        { typeof(int), "0" },
        { typeof(long), "0" },
        { typeof(sbyte), "0" },
        { typeof(ushort), "0" },
        { typeof(uint), "0" },
        { typeof(ulong), "0" },
        { typeof(float), "0" },
        { typeof(double), "0" },
        { typeof(decimal), "0" },
    };

    private static readonly Dictionary<string, string> JavaScriptRelativeTypes = new Dictionary<string, string>
    {
        { "bool", "boolean" },
        { "Boolean", "boolean" },
        { "string", "string" },
        { "String", "string" },
        { "char", "string" },
        { "Guid", "string" },
        { "DateTime", "Date" },
        { "TimeSpan", "string" },
        { "byte", "number" },
        { "short", "number" },
        { "int", "number" },
        { "long", "number" },
        { "sbyte", "number" },
        { "ushort", "number" },
        { "uint", "number" },
        { "ulong", "number" },
        { "Int32", "number" },
        { "Int64", "number" },
        { "float", "number" },
        { "double", "number" },
        { "decimal", "number" },
    };

    /// <summary>
    /// Extract description from type.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static TypeDescription ExtractTypeDescription(Type type)
    {
        try
        {
            if (type == null)
            {
                return new TypeDescription();
            }

            TypeDescription description = new TypeDescription();
            description.IsCollection = type.GetInterface(nameof(IEnumerable)) != null && type != typeof(string);
            description.IsGenericType = type.GetGenericArguments()?.Any() ?? false;

            if (description.IsCollection)
            {
                type = type.GetGenericArguments().FirstOrDefault() ?? type;
            }

            if (type.IsArray)
            {
                type = type.GetElementType();
            }

            description.IsNullable = Nullable.GetUnderlyingType(type) != null;
            description.IsEnum = type.IsEnum;
            bool isPrimitiveType = false;

            if (PrimitiveTypes.ContainsKey(type))
            {
                description.Name = PrimitiveTypes[type];
                description.FullName = description.Name;
                description.JavaScriptTypeName = JavaScriptRelativeTypes[description.Name];
                isPrimitiveType = true;
            }

            if (description.IsNullable && PrimitiveTypes.ContainsKey(Nullable.GetUnderlyingType(type)))
            {
                description.Name = PrimitiveTypes[Nullable.GetUnderlyingType(type)];
                description.FullName = description.Name;
                description.JavaScriptTypeName = JavaScriptRelativeTypes[description.Name];
                isPrimitiveType = true;
            }

            if (!isPrimitiveType && !description.IsEnum)
            {
                description.IsComplex = true;
                description.Name = type.Name;
                description.FullName = type.FullName;
                description.JavaScriptTypeName = description.Name;
            }

            if (!isPrimitiveType && description.IsGenericType && !description.IsCollection)
            {
                description.Name = GetGenericTypeClearName(description.Name);
                description.GenericType = ExtractTypeDescription(type.GetGenericArguments().FirstOrDefault());
                description.JavaScriptTypeName = description.Name;
            }

            if (description.IsCollection)
            {
                description.JavaScriptTypeName = GetJavaScriptCollectionType(description.JavaScriptTypeName);
            }

            if (description.IsEnum)
            {
                description.Name = type.Name;
                description.FullName = type.FullName;
                description.JavaScriptTypeName = JavaScriptRelativeTypes["int"];
                description.EnumValues = new Dictionary<string, int>();
                var enumValues = Enum.GetValues(type);
                foreach (var value in enumValues)
                {
                    description.EnumValues[value.ToString()] = (int)Enum.Parse(type, value.ToString());
                }
            }

            if (description.IsComplex)
            {
                var properties = type.GetProperties();
                foreach (var propertyInfo in properties)
                {
                    if (!propertyInfo.IsPropertyStatic() && !propertyInfo.HasAttribute<IgnorePropertyAttribute>())
                    {
                        PropertyDescription propertyDescription = new PropertyDescription();
                        propertyDescription.Name = propertyInfo.Name;
                        propertyDescription.ReadOnly = propertyInfo.HasAttribute<ReadOnlyAttribute>();
                        propertyDescription.Type = ExtractTypeDescription(propertyInfo.PropertyType);
                        propertyDescription.DefaultValue = DefaultValues.ContainsKey(propertyInfo.PropertyType) ? DefaultValues[propertyInfo.PropertyType] : "null";
                        description.Properties.Add(propertyDescription);
                    }
                }
            }

            return description;
        }
        catch (Exception)
        {
            throw new ArgumentException($"Invalid type extraction for type '{type.FullName}'");
        }
    }

    /// <summary>
    /// Extract description from response type.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static ResponseDescription ExtractResponseDescription(Type type)
    {
        if (type == null)
        {
            return new ResponseDescription { Void = true };
        }

        return new ResponseDescription
        {
            Type = ExtractTypeDescription(type),
        };
    }

    /// <summary>
    /// Extract description from argument type.
    /// </summary>
    /// <param name="name"></param>
    /// <param name="type"></param>
    /// <returns></returns>
    public static ArgumentDescription ExtractArgumentDescription(string name, Type type)
    {
        if (type == null)
        {
            throw new NullReferenceException($"Description argument type for {name} cannot be null");
        }

        return new ArgumentDescription
        {
            Name = name,
            Type = ExtractTypeDescription(type),
        };
    }

    /// <summary>
    /// Extract descriptions from classes types.
    /// </summary>
    /// <param name="classes"></param>
    /// <returns></returns>
    public static List<TypeDescription> ExtractUniqueClassesFromClasses(List<TypeDescription> classes)
    {
        var tempClasses = new List<TypeDescription>();
        foreach (var classItem in classes)
        {
            tempClasses.Add(classItem);
            tempClasses.AddRange(ExtractInnerClassDescriptions(classItem));
        }

        var resultClasses = new List<TypeDescription>();
        foreach (var tempClass in tempClasses)
        {
            if (resultClasses.All(x => x.FullNameWithGeneric != tempClass.FullNameWithGeneric))
            {
                resultClasses.Add(tempClass);
            }
        }

        return resultClasses;
    }

    /// <summary>
    /// Extract descriptions of inner classes from class type.
    /// </summary>
    /// <param name="classDescription"></param>
    /// <returns></returns>
    public static List<TypeDescription> ExtractInnerClassDescriptions(TypeDescription classDescription)
    {
        var resultClasses = new List<TypeDescription>();
        var classProperties = classDescription.Properties;
        foreach (var property in classProperties)
        {
            if (property.Type.IsComplex)
            {
                resultClasses.Add(property.Type);
                resultClasses.AddRange(ExtractInnerClassDescriptions(property.Type));
            }
        }

        return resultClasses;
    }

    /// <summary>
    /// Extract enums description from classes types.
    /// </summary>
    /// <param name="classes"></param>
    /// <returns></returns>
    public static List<TypeDescription> ExtractUniqueEnumsFromClasses(List<TypeDescription> classes)
    {
        var tempClasses = new List<TypeDescription>();
        foreach (var classItem in classes)
        {
            tempClasses.Add(classItem);
            tempClasses.AddRange(ExtractInnerClassDescriptions(classItem));
        }

        var resultEnumsTypes = new List<TypeDescription>();

        foreach (var tempClass in tempClasses)
        {
            foreach (var tempClassProperty in tempClass.Properties)
            {
                if (tempClassProperty.Type.IsEnum && resultEnumsTypes.All(x => x.FullNameWithGeneric != tempClassProperty.Type.FullNameWithGeneric))
                {
                    resultEnumsTypes.Add(tempClassProperty.Type);
                }
            }
        }

        return resultEnumsTypes;
    }

    private static bool IsPropertyStatic(this PropertyInfo propertyInfo)
    {
        return propertyInfo.GetAccessors().Any(x => x.IsStatic);
    }

    private static string GetJavaScriptCollectionType(string type)
    {
        return $"Array<{type}>";
    }

    private static string GetGenericTypeClearName(string name)
    {
        return name.Split('`').FirstOrDefault() ?? name;
    }
}