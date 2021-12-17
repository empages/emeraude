using System;
using System.Collections.Generic;
using System.IO;
using Emeraude.Cli.Commands.Implementations.EmPage.Templates;
using Emeraude.Cli.Properties;
using Emeraude.Essentials.Helpers;

namespace Emeraude.Cli.Commands.Implementations.EmPage;

/// <summary>
/// Command for creating a new EmPage.
/// </summary>
internal class EmPageCommand : Command
{
    /// <inheritdoc/>
    internal override void Execute(Dictionary<string, string> parameters)
    {
        if (this.CliConfig != null)
        {
            if (parameters.ContainsKey(CommandParameters.Name) && !string.IsNullOrWhiteSpace(parameters[CommandParameters.Name]))
            {
                string pageName = parameters[CommandParameters.Name]
                    .Replace("-", string.Empty)
                    .Replace(" ", string.Empty);

                string pagePath = Path.Combine(this.CliConfigDirectory, Constants.SourceFolder, $"{this.CliConfig.Base.ProjectName}.Admin", "EmPages", pageName);
                this.CreateEmPage(pageName, pagePath);
            }
            else
            {
                Console.WriteLine(Messages.InvalidCliCommandUsage);
            }
        }
        else
        {
            Console.WriteLine(Messages.MissedCliConfigFile);
        }
    }

    private Dictionary<string, object> BuildSessionDictionary(string pageName)
    {
        return new Dictionary<string, object>
        {
            { "PageName", pageName },
            { "PageTitle", StringUtilities.SplitWordsByCapitalLetters(pageName) },
            { "PageRoute", StringUtilities.SimpleConvertToSlug(pageName) },
            { "ProjectName", this.CliConfig.Base.ProjectName },
        };
    }

    private void CreateEmPage(string pageName, string pagePath)
    {
        if (Directory.Exists(pagePath))
        {
            Console.WriteLine(Messages.InvalidEmPageName);
            return;
        }

        Directory.CreateDirectory(pagePath);

        var sessionDictionary = this.BuildSessionDictionary(pageName);
        var schemaFilePath = Path.Combine(pagePath, $"{pageName}EmPageSchema.cs");
        var modelFilePath = Path.Combine(pagePath, $"{pageName}EmPageModel.cs");
        var dataManagerFilePath = Path.Combine(pagePath, $"{pageName}EmPageDataManager.cs");
        var dataStrategyFilePath = Path.Combine(pagePath, $"{pageName}EmPageDataStrategy.cs");

        File.WriteAllText(schemaFilePath, TemplateRenderer.RenderTemplate(typeof(SchemaTemplate), sessionDictionary));
        File.WriteAllText(modelFilePath, TemplateRenderer.RenderTemplate(typeof(ModelTemplate), sessionDictionary));
        File.WriteAllText(dataManagerFilePath, TemplateRenderer.RenderTemplate(typeof(DataManagerTemplate), sessionDictionary));
        File.WriteAllText(dataStrategyFilePath, TemplateRenderer.RenderTemplate(typeof(DataStrategyTemplate), sessionDictionary));
    }
}