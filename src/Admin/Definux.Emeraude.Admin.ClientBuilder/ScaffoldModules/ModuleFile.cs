using System;
using System.Collections.Generic;
using System.Text;
using System.Text.Json.Serialization;

namespace Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules
{
    public class ModuleFile
    {
        public string Name { get; set; }

        public string RelativePath { get; set; }

        [JsonIgnore]
        public Type TemplateType { get; set; }

        public string ReferenceId { get; set; }

        [JsonIgnore]
        public Func<ModuleFile, string> RenderFunction { get; set; }

        public string RenderTemplate(Dictionary<string, object> sessionDictionary)
        {
            return TemplateRenderer.RenderTemplate(TemplateType, sessionDictionary);
        }

        public string RenderTemplate()
        {
            return TemplateRenderer.RenderTemplate(TemplateType, new Dictionary<string, object>());
        }
    }
}
