using System;
using System.Collections.Generic;
using System.Linq;
using Essentials.Extensions;

namespace EmPages.Pages;

/// <summary>
/// Type wrapper for the needs of Emerald Pages models.
/// </summary>
public class EmType
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmType"/> class.
    /// </summary>
    /// <param name="type"></param>
    public EmType(Type type)
    {
        if (!EmPageValidators.IsTypeSupported(type))
        {
            throw new ArgumentException("Cannot be constructed EmType with an unsupported type");
        }

        this.IsPrimitive =
            EmPageStaticData.SupportedPrimitivesTypes.Contains(type) ||
            EmPageStaticData.SupportedNullablePrimitivesTypes.Contains(type);

        var isEnumerable = type.IsEnumerableType();
        var isGeneric = type.IsConstructedGenericType;
        if (isEnumerable && isGeneric)
        {
            this.SourceType = type.GetGenericArguments().First();
            this.IsEnumerable = true;
            this.IsNullable = true;
            this.IsEnum = this.SourceType.IsEnum;
            this.Group = TypeGroup.Arrays;
            return;
        }

        this.SourceType = type.GetTypeByIgnoreTheNullable();
        this.IsNullable = EmPageStaticData.SupportedNullablePrimitivesTypes.Contains(type) || Nullable.GetUnderlyingType(type) != null;
        this.IsEnum = this.SourceType.IsEnum;

        if (this.IsEnum)
        {
            this.Group = TypeGroup.Enumerations;
        }
        else if (EmPageStaticData.TextsGroupTypes.Contains(this.SourceType))
        {
            this.Group = TypeGroup.Texts;
        }
        else if (EmPageStaticData.NumbersGroupTypes.Contains(this.SourceType))
        {
            this.Group = TypeGroup.Numbers;
        }
        else if (EmPageStaticData.BooleansGroupTypes.Contains(this.SourceType))
        {
            this.Group = TypeGroup.Booleans;
        }
        else if (EmPageStaticData.DateTimesGroupTypes.Contains(this.SourceType))
        {
            this.Group = TypeGroup.DateTimes;
        }
    }

    /// <summary>
    /// Flat that indicates whether the type is primitive.
    /// </summary>
    public bool IsPrimitive { get; }

    /// <summary>
    /// Flag that indicates whether the type can receive null values.
    /// </summary>
    public bool IsNullable { get; }

    /// <summary>
    /// Flag that indicates whether the type is enumerable.
    /// </summary>
    public bool IsEnumerable { get; }

    /// <summary>
    /// Flag that indicates whether the type is enumeration.
    /// </summary>
    public bool IsEnum { get; }

    /// <summary>
    /// Source type.
    /// </summary>
    public Type SourceType { get; }

    /// <summary>
    /// Type group.
    /// </summary>
    public TypeGroup Group { get; }
}