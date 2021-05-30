using System;
using System.Collections.Generic;
using System.IO;
using Definux.Emeraude.Cli.Commands.Implementations.Page.Templates;
using Definux.Emeraude.Cli.Properties;
using Definux.Utilities.Functions;

namespace Definux.Emeraude.Cli.Commands.Implementations.Page
{
    /// <summary>
    /// Command for creating a new EmPage.
    /// </summary>
    internal class PageCommand : Command
    {
        /// <inheritdoc/>
        internal override void Execute(Dictionary<string, string> parameters)
        {
            if (this.CliConfig != null)
            {
                if (parameters.ContainsKey(CommandParameters.Name) && !string.IsNullOrWhiteSpace(parameters[CommandParameters.Name]))
                {
                    string modifiedPageName = parameters[CommandParameters.Name]
                        .Replace("-", string.Empty)
                        .Replace(" ", string.Empty)
                        .Replace("_", string.Empty);

                    string pagesPath = Path.Combine(this.CliConfigDirectory, Constants.SourceFolder, this.CliConfig.Base.ProjectName, "Pages");
                    string initialStateRequestsPath = Path.Combine(this.CliConfigDirectory, Constants.SourceFolder, $"{this.CliConfig.Base.ProjectName}.Application", "Requests", "InitialStates", modifiedPageName);

                    this.CreatePageClasses(modifiedPageName, pagesPath, initialStateRequestsPath);
                }
            }
            else
            {
                Console.WriteLine(Messages.MissedCliConfigFile);
            }
        }

        private Dictionary<string, object> BuildSessionDictionary(string pageName)
        {
            string pageRoute = StringFunctions.SplitWordsByCapitalLetters(pageName)
                .Replace(" ", "-")
                .ToLower();

            return new Dictionary<string, object>
            {
                { "PageName", pageName },
                { "PageRoute", pageRoute },
                { "ProjectName", this.CliConfig.Base.ProjectName },
            };
        }

        private void CreatePageClasses(string pageName, string pagesPath, string initialStateRequestsPath)
        {
            var sessionDictionary = this.BuildSessionDictionary(pageName);
            var pageFilePath = Path.Combine(pagesPath, $"{pageName}Page.cs");
            var viewModelFilePath = Path.Combine(initialStateRequestsPath, $"{pageName}ViewModel.cs");
            var initialStateQueryFilePath = Path.Combine(initialStateRequestsPath, $"{pageName}InitialStateQuery.cs");

            if (!File.Exists(pageFilePath) &&
                !File.Exists(viewModelFilePath) &&
                !File.Exists(initialStateQueryFilePath))
            {
                if (!Directory.Exists(pagesPath))
                {
                    Directory.CreateDirectory(pagesPath);
                }

                File.WriteAllText(pageFilePath, TemplateRenderer.RenderTemplate(typeof(PageTemplate), sessionDictionary));

                if (!Directory.Exists(initialStateRequestsPath))
                {
                    Directory.CreateDirectory(initialStateRequestsPath);
                }

                File.WriteAllText(viewModelFilePath, TemplateRenderer.RenderTemplate(typeof(ViewModelTemplate), sessionDictionary));
                File.WriteAllText(initialStateQueryFilePath, TemplateRenderer.RenderTemplate(typeof(InitialStateQueryTemplate), sessionDictionary));

                Console.WriteLine(Messages.PageSuccessfullyCreated);
            }
            else
            {
                Console.WriteLine(Messages.FileExistMessage);
            }
        }
    }
}
