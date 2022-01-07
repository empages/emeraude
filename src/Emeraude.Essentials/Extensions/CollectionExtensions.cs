using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using Emeraude.Essentials.Enumerations;
using Emeraude.Essentials.Helpers;

namespace Emeraude.Essentials.Extensions;

/// <summary>
/// Extensions for any collection types (IEnumerable, IQueryable).
/// </summary>
public static class CollectionExtensions
{
    /// <summary>
    /// Order collection by specified <see cref="OrderType"/>.
    /// </summary>
    /// <param name="collection"></param>
    /// <param name="orderType"></param>
    /// <param name="orderExpression"></param>
    /// <typeparam name="T">Collection parameter.</typeparam>
    /// <returns></returns>
    public static IOrderedEnumerable<T> OrderByType<T>(
        this IEnumerable<T> collection,
        OrderType orderType,
        Func<T, object> orderExpression) =>
        orderType != OrderType.Descending
            ? collection.OrderBy(orderExpression)
            : collection.OrderByDescending(orderExpression);

    /// <summary>
    /// Order collection by specified order type.
    /// </summary>
    /// <param name="collection"></param>
    /// <param name="orderType"></param>
    /// <param name="orderExpression"></param>
    /// <typeparam name="T">Collection parameter.</typeparam>
    /// <returns></returns>
    public static IOrderedEnumerable<T> OrderByType<T>(
        this IEnumerable<T> collection,
        string orderType,
        Func<T, object> orderExpression) =>
        collection.OrderByType(EnumUtilities.GetOrderTypeByString(orderType), orderExpression);

    /// <summary>
    /// Order collection by specified <see cref="OrderType"/>.
    /// </summary>
    /// <param name="collection"></param>
    /// <param name="orderType"></param>
    /// <param name="orderExpression"></param>
    /// <typeparam name="T">Collection parameter.</typeparam>
    /// <returns></returns>
    public static IOrderedQueryable<T> OrderByType<T>(
        this IQueryable<T> collection,
        OrderType orderType,
        Expression<Func<T, object>> orderExpression) =>
        orderType != OrderType.Descending
            ? collection.OrderBy(orderExpression)
            : collection.OrderByDescending(orderExpression);

    /// <summary>
    /// Order collection by specified type.
    /// </summary>
    /// <param name="collection"></param>
    /// <param name="orderType"></param>
    /// <param name="orderExpression"></param>
    /// <typeparam name="T">Collection parameter.</typeparam>
    /// <returns></returns>
    public static IOrderedQueryable<T> OrderByType<T>(
        this IQueryable<T> collection,
        string orderType,
        Expression<Func<T, object>> orderExpression) =>
        collection.OrderByType(EnumUtilities.GetOrderTypeByString(orderType), orderExpression);
}