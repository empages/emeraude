using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules
{
    public static class TemplateRenderer
    {
        public static string RenderTemplate(Type templateType, Dictionary<string, object> sessionDictionary)
        {
            var templateInstance = Activator.CreateInstance(templateType);
            templateType.GetProperty("Session")?.SetValue(templateInstance, sessionDictionary);
            object templateContentObject = templateType.GetMethod("TransformText")?.Invoke(templateInstance, null);

            return templateContentObject?.ToString();
        }
    }
}
