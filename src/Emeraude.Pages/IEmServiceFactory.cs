using System;

namespace Emeraude.Pages;

/// <summary>
/// Factory for creating services related to Emeraude pages.
/// </summary>
public interface IEmServiceFactory
{
    /// <summary>
    /// Creates a page for a specified type.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    IEmPage CreatePage(Type type);

    /// <summary>
    /// Creates command for a specified type.
    /// </summary>
    /// <param name="type"></param>
    /// <returns></returns>
    IEmPageCommand CreateCommand(Type type);
}