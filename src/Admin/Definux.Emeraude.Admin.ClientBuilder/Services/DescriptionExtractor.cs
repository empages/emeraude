using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Definux.Emeraude.Admin.ClientBuilder.Models;
using Definux.Emeraude.Client.EmPages.Attributes;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.ClientBuilder.Services
{
    /// <summary>
    /// Static class which provide methods for simplified type description extraction.
    /// </summary>
    public static class DescriptionExtractor
    {
        private static Dictionary<Type, string> primitiveTypes = new Dictionary<Type, string>
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

        private static Dictionary<Type, string> defaultValues = new Dictionary<Type, string>
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

        private static Dictionary<string, string> javaScriptRelativeTypes = new Dictionary<string, string>
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
        /// Extract description from class type.
        /// </summary>
        /// <param name="type"></param>
        /// <returns></returns>
        public static ClassDescription ExtractClassDescription(Type type)
        {
            try
            {
                if (type == null)
                {
                    return new ClassDescription();
                }

                ClassDescription classDescription = new ClassDescription();
                Type workType = type;
                if (workType.GetInterface(nameof(IEnumerable)) != null && !primitiveTypes.ContainsKey(workType))
                {
                    workType = type.GetGenericArguments().FirstOrDefault();
                    if (workType == null)
                    {
                        throw new NullReferenceException($"Generic parameter of {type.FullName} cannot be extracted.");
                    }
                }

                classDescription.Name = workType.Name;
                classDescription.FullName = workType.FullName;
                classDescription.IsComplex = !primitiveTypes.ContainsKey(workType);
                if (classDescription.IsComplex)
                {
                    classDescription.JavaScriptTypeName = classDescription.Name;
                }
                else
                {
                    classDescription.JavaScriptTypeName = javaScriptRelativeTypes[classDescription.Name];
                }

                var classProperties = workType.GetProperties();
                foreach (var propertyInfo in classProperties)
                {
                    if (!propertyInfo.IsPropertyStatic())
                    {
                        PropertyDescription propertyDescription = new PropertyDescription();
                        propertyDescription.Name = propertyInfo.Name;
                        propertyDescription.ReadOnly = propertyInfo.HasAttribute<EmReadOnlyAttribute>();
                        propertyDescription.Type = ExtractTypeDescription(propertyInfo.PropertyType);
                        propertyDescription.DefaultValue = defaultValues.ContainsKey(propertyInfo.PropertyType) ? defaultValues[propertyInfo.PropertyType] : "null";
                        classDescription.Properties.Add(propertyDescription);
                    }
                }

                return classDescription;
            }
            catch (Exception ex)
            {
                throw new ArgumentException($"Invalid class extraction for class {type.FullName}. {ex.Message}");
            }
        }

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

                TypeDescription typeDescription = new TypeDescription();
                typeDescription.IsCollection = type.GetInterface(nameof(IEnumerable)) != null && type != typeof(string);
                if (typeDescription.IsCollection)
                {
                    type = type.GetGenericArguments().FirstOrDefault() ?? type;
                }

                if (type.IsArray)
                {
                    type = type.GetElementType();
                }

                typeDescription.IsNullable = Nullable.GetUnderlyingType(type) != null;
                typeDescription.IsEnum = type.IsEnum;
                bool isPrimitiveType = false;

                if (primitiveTypes.ContainsKey(type))
                {
                    typeDescription.Name = primitiveTypes[type];
                    typeDescription.FullName = typeDescription.Name;
                    typeDescription.JavaScriptTypeName = javaScriptRelativeTypes[typeDescription.Name];
                    isPrimitiveType = true;
                }

                if (typeDescription.IsNullable && primitiveTypes.ContainsKey(Nullable.GetUnderlyingType(type)))
                {
                    typeDescription.Name = primitiveTypes[Nullable.GetUnderlyingType(type)];
                    typeDescription.FullName = typeDescription.Name;
                    typeDescription.JavaScriptTypeName = javaScriptRelativeTypes[typeDescription.Name];
                    isPrimitiveType = true;
                }

                if (!isPrimitiveType && !typeDescription.IsEnum)
                {
                    typeDescription.ComplexType = ExtractClassDescription(type);
                    typeDescription.Name = typeDescription.ComplexType.Name;
                    typeDescription.FullName = type.FullName;
                    typeDescription.JavaScriptTypeName = typeDescription.ComplexType.Name;
                }

                if (typeDescription.IsEnum)
                {
                    typeDescription.Name = type.Name;
                    typeDescription.FullName = type.FullName;
                    typeDescription.JavaScriptTypeName = javaScriptRelativeTypes["int"];
                    typeDescription.EnumValues = new Dictionary<string, int>();
                    var enumValues = Enum.GetValues(type);
                    foreach (var value in enumValues)
                    {
                        typeDescription.EnumValues[value.ToString()] = (int)Enum.Parse(type, value.ToString());
                    }
                }

                return typeDescription;
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
                Class = ExtractClassDescription(type),
                IsCollection = type.GetInterface(nameof(IEnumerable)) != null,
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
                Class = ExtractClassDescription(type),
                IsCollection = type.GetInterface(nameof(IEnumerable)) != null,
            };
        }

        /// <summary>
        /// Extract descriptions from classes types.
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public static List<ClassDescription> ExtractUniqueClassesFromClasses(List<ClassDescription> classes)
        {
            var tempClasses = new List<ClassDescription>();
            foreach (var classItem in classes)
            {
                tempClasses.Add(classItem);
                tempClasses.AddRange(ExtractInnerClassDescriptions(classItem));
            }

            var resultClasses = new List<ClassDescription>();
            foreach (var tempClass in tempClasses)
            {
                if (!resultClasses.Any(x => x.FullName == tempClass.FullName))
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
        public static List<ClassDescription> ExtractInnerClassDescriptions(ClassDescription classDescription)
        {
            var resultClasses = new List<ClassDescription>();
            var classProperties = classDescription.Properties;
            foreach (var property in classProperties)
            {
                if (property.Type.IsComplexType)
                {
                    resultClasses.Add(property.Type.ComplexType);
                    resultClasses.AddRange(ExtractInnerClassDescriptions(property.Type.ComplexType));
                }
            }

            return resultClasses;
        }

        /// <summary>
        /// Extract enums description from classes types.
        /// </summary>
        /// <param name="classes"></param>
        /// <returns></returns>
        public static List<TypeDescription> ExtractUniqueEnumsFromClasses(List<ClassDescription> classes)
        {
            var tempClasses = new List<ClassDescription>();
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
                    if (tempClassProperty.Type.IsEnum && !resultEnumsTypes.Any(x => x.FullName == tempClassProperty.Type.FullName))
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
    }
}
