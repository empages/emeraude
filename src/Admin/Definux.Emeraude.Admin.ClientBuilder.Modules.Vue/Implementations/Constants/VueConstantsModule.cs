using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions;
using Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates;
using Definux.Emeraude.Admin.ClientBuilder.ScaffoldModules;
using Definux.Utilities.Extensions;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants
{
    /// <summary>
    /// Vue constants module for generation constants values for transfer data from back-end to front-end.
    /// </summary>
    public class VueConstantsModule : VueScaffoldModule
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="VueConstantsModule"/> class.
        /// </summary>
        public VueConstantsModule()
            : base("Vue Constants", true)
        {
        }

        /// <inheritdoc />
        public override void DefineFiles()
        {
            string relativePath = Path.Combine(this.Options.WebAppPath, VueAppFolders.Shared);

            this.AddFile(new ModuleFile
            {
                Name = "constants.js",
                RelativePath = relativePath,
                TemplateType = typeof(ConstantsTemplate),
                RenderFunction = this.RenderConstants,
            });
        }

        /// <inheritdoc />
        public override void DefineFolders()
        {
            this.AddFolder(new ModuleFolder
            {
                Name = VueAppFolders.Shared,
                RelativePath = this.Options.WebAppPath,
            });
        }

        private string RenderConstants(ModuleFile file)
        {
            var constantDictionaries = this.Options.ConstantsTypes
                .ToDictionary(
                    tk => tk.Name,
                    tv =>
                        tv.GetFields(BindingFlags.Public | BindingFlags.Static | BindingFlags.FlattenHierarchy)
                        .Where(xx => xx.IsLiteral && !xx.IsInitOnly)
                        .ToDictionary(
                            k => StringFunctions.ConvertToKey(k.Name),
                            v => this.ConvertToJavaScriptValue(v.GetRawConstantValue())));

            if (this.Options.Constants.Count > 0)
            {
                constantDictionaries["ConstantsExposedByTheApplication"] = this.Options.Constants
                    .ToDictionary(
                        x => StringFunctions.ConvertToKey(x.Key),
                        x => this.ConvertToJavaScriptValue(x.Value));
            }

            return file.RenderTemplate(new Dictionary<string, object>
            {
                { "Constants", constantDictionaries },
            });
        }

        private string ConvertToJavaScriptValue(object value)
        {
            if (value == null)
            {
                return "null";
            }

            if (value.GetType().IsNumericType() || value is bool)
            {
                return value.ToString();
            }

            return $"'{value}'";
        }
    }
}
