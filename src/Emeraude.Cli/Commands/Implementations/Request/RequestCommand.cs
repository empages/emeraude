using System;
using System.Collections.Generic;
using System.IO;
using Emeraude.Cli.Commands.Implementations.Request.Templates;
using Emeraude.Cli.Properties;

namespace Emeraude.Cli.Commands.Implementations.Request;

/// <summary>
/// Command for creating a new request (query or comment).
/// </summary>
internal class RequestCommand : Command
{
    private const string QueryRequestType = "Query";
    private const string CommandRequestType = "Command";

    private Dictionary<string, string> requestsFolderNames = new Dictionary<string, string>
    {
        { QueryRequestType, "Queries" },
        { CommandRequestType, "Commands" },
    };

    /// <inheritdoc/>
    internal override void Execute(Dictionary<string, string> parameters)
    {
        if (this.CliConfig != null)
        {
            if (parameters.ContainsKey(CommandParameters.Name) && !string.IsNullOrWhiteSpace(parameters[CommandParameters.Name]))
            {
                if (!parameters[CommandParameters.Name].EndsWith(QueryRequestType) && !parameters[CommandParameters.Name].EndsWith(CommandRequestType))
                {
                    Console.WriteLine(Messages.InvalidRequestCommand);
                    return;
                }

                string requestName = parameters[CommandParameters.Name]
                    .Replace("-", string.Empty)
                    .Replace(" ", string.Empty);

                string requestType = requestName.EndsWith(QueryRequestType) ? QueryRequestType : CommandRequestType;

                requestName = requestName.Substring(0, requestName.Length - requestType.Length);

                string requestPath = Path.Combine(this.CliConfigDirectory, Constants.SourceFolder, $"{this.CliConfig.Base.ProjectName}.Application", "Requests", this.requestsFolderNames[requestType], requestName);

                this.CreateRequest(requestName, requestType, requestPath);
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

    private Dictionary<string, object> BuildSessionDictionary(string requestName, string requestType)
    {
        return new Dictionary<string, object>
        {
            { "RequestName", requestName },
            { "RequestType", requestType },
            { "RequestFolder", this.requestsFolderNames[requestType] },
            { "ProjectName", this.CliConfig.Base.ProjectName },
        };
    }

    private void CreateRequest(string requestName, string requestType, string requestPath)
    {
        var sessionDictionary = this.BuildSessionDictionary(requestName, requestType);
        var resultFilePath = Path.Combine(requestPath, $"{requestName}Result.cs");

        if (File.Exists(resultFilePath))
        {
            Console.WriteLine(Messages.FileExistMessage);
            return;
        }

        if (!Directory.Exists(requestPath))
        {
            Directory.CreateDirectory(requestPath);
        }

        if (requestType == QueryRequestType)
        {
            var queryFilePath = Path.Combine(requestPath, $"{requestName}Query.cs");

            if (File.Exists(queryFilePath))
            {
                Console.WriteLine(Messages.FileExistMessage);
                return;
            }

            File.WriteAllText(queryFilePath, TemplateRenderer.RenderTemplate(typeof(QueryTemplate), sessionDictionary));
            File.WriteAllText(resultFilePath, TemplateRenderer.RenderTemplate(typeof(ResultTemplate), sessionDictionary));

            Console.WriteLine(Messages.QuerySuccessfullyCreated);
        }
        else if (requestType == CommandRequestType)
        {
            var requestFilePath = Path.Combine(requestPath, $"{requestName}Request.cs");
            var commandFilePath = Path.Combine(requestPath, $"{requestName}Command.cs");
            var commandValidatorFilePath = Path.Combine(requestPath, $"{requestName}CommandValidator.cs");

            if (File.Exists(requestFilePath) || File.Exists(commandFilePath) || File.Exists(commandValidatorFilePath))
            {
                Console.WriteLine(Messages.FileExistMessage);
                return;
            }

            File.WriteAllText(requestFilePath, TemplateRenderer.RenderTemplate(typeof(RequestTemplate), sessionDictionary));
            File.WriteAllText(commandFilePath, TemplateRenderer.RenderTemplate(typeof(CommandTemplate), sessionDictionary));
            File.WriteAllText(commandValidatorFilePath, TemplateRenderer.RenderTemplate(typeof(CommandValidatorTemplate), sessionDictionary));
            File.WriteAllText(resultFilePath, TemplateRenderer.RenderTemplate(typeof(ResultTemplate), sessionDictionary));

            Console.WriteLine(Messages.CommandSuccessfullyCreated);
        }
        else
        {
            Console.WriteLine(Messages.RequestCannotBeCreated);
        }
    }
}