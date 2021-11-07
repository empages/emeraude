using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Cli.Commands
{
    /// <summary>
    /// Template renderer for T4 templates.
    /// </summary>
    internal static class TemplateRenderer
    {
        /// <summary>
        /// Render T4 template by its assembly type.
        /// </summary>
        /// <param name="templateType"></param>
        /// <param name="sessionDictionary"></param>
        /// <returns></returns>
        internal static string RenderTemplate(Type templateType, Dictionary<string, object> sessionDictionary)
        {
            var templateInstance = Activator.CreateInstance(templateType);
            templateType.GetProperty("Session")?.SetValue(templateInstance, sessionDictionary);
            object templateContentObject = templateType.GetMethod("TransformText")?.Invoke(templateInstance, null);

            return templateContentObject?.ToString();
        }
    }
}
