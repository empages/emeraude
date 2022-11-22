using System;
using System.ComponentModel;

namespace EmPages.Pages;

/// <summary>
/// Type converter that helps the string parsing.
/// </summary>
public static class EmPageTypeConverter
{
    /// <summary>
    /// Changes type.
    /// </summary>
    /// <param name="value"></param>
    /// <typeparam name="T">Target type.</typeparam>
    /// <returns></returns>
    public static T ConvertToType<T>(object value)
    {
        try
        {
            return (T)ChangeType(typeof(T), value?.ToString());
        }
        catch
        {
            return default;
        }
    }

    private static object ChangeType(Type type, object value)
    {
        if (type == typeof(string))
        {
            return value;
        }

        TypeConverter converter = TypeDescriptor.GetConverter(type);
        return converter.ConvertFrom(value);
    }
}