﻿using System;
using System.Collections.Generic;

namespace Emeraude.Essentials.Helpers;

/// <summary>
/// Helper renderer class for T4 templates.
/// </summary>
public static class T4TemplateRenderer
{
    /// <summary>
    /// Execution method of the renderer.
    /// </summary>
    /// <param name="templateType"></param>
    /// <param name="sessionDictionary"></param>
    /// <returns></returns>
    public static string RenderTemplate(Type templateType, Dictionary<string, object> sessionDictionary)
    {
        var templateInstance = Activator.CreateInstance(templateType);
        templateType.GetProperty("Session")?.SetValue(templateInstance, sessionDictionary);
        object templateContentObject = templateType.GetMethod("TransformText")?.Invoke(templateInstance, null);

        return templateContentObject?.ToString();
    }
}