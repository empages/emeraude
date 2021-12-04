using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Emeraude.Cli.Properties;
using LibGit2Sharp;

namespace Emeraude.Cli.Commands.Implementations.Create;

/// <summary>
/// Command for creating the startup project.
/// </summary>
internal class CreateCommand : Command
{
    private const string StartupProjectName = "Emeraude.StartupTemplate";
    private const string EmStartupGitHubRepositoryUrl = "https://github.com/emeraudeframework/startup-template.git";

    /// <inheritdoc/>
    internal override void Execute(Dictionary<string, string> parameters)
    {
        if (parameters.ContainsKey(CommandParameters.Name) && !string.IsNullOrWhiteSpace(parameters[CommandParameters.Name]))
        {
            string modifiedProjectName = parameters[CommandParameters.Name].Replace("-", "_").Replace(" ", "_");
            this.CreateProject(modifiedProjectName);
        }
        else
        {
            Console.WriteLine(Messages.ProjectRequiresAName);
        }
    }

    private void CreateProject(string projectName)
    {
        string saveDirectory = Path.Combine(Directory.GetCurrentDirectory(), projectName);

        Repository.Clone(EmStartupGitHubRepositoryUrl, saveDirectory);

        this.DeleteUnnecessaryFolders(saveDirectory);
        this.DeleteUnnecessaryFiles(saveDirectory);
        this.RenameProjectFolders(saveDirectory, projectName);
        this.RenameProjectFiles(saveDirectory, projectName);
        this.ModifyFilesContent(saveDirectory, projectName);

        Console.WriteLine(Messages.ProjectSuccessfullyCreated);
    }

    private void DeleteUnnecessaryFolders(string directory)
    {
        string[] unnecessaryFolders =
        {
            ".git",
        };

        var existingFolders = Directory.GetDirectories(directory, "*", SearchOption.AllDirectories);

        foreach (var folderPath in existingFolders)
        {
            var folderInfo = new DirectoryInfo(folderPath);
            if (unnecessaryFolders.Contains(folderInfo.Name))
            {
                folderInfo.Attributes = FileAttributes.Normal;
                Utilities.RecursiveDelete(folderInfo);
            }
        }
    }

    private void DeleteUnnecessaryFiles(string directory)
    {
        string[] unnecessaryFiles =
        {
        };

        var existingFiles = Directory.GetFiles(directory, "*", SearchOption.AllDirectories);

        foreach (var filePath in existingFiles)
        {
            var fileInfo = new FileInfo(filePath);
            if (unnecessaryFiles.Contains(fileInfo.Name))
            {
                fileInfo.Attributes = FileAttributes.Normal;
                fileInfo.Delete();
            }
        }
    }

    private void RenameProjectFolders(string directory, string projectName)
    {
        var existingFolders = Directory.GetDirectories(directory, "*", SearchOption.AllDirectories);
        foreach (var folderPath in existingFolders)
        {
            var folderInfo = new DirectoryInfo(folderPath);
            this.MoveFolderIfContainsName(folderInfo, StartupProjectName, projectName);
        }
    }

    private void RenameProjectFiles(string directory, string projectName)
    {
        var existingFiles = Directory.GetFiles(directory, "*", SearchOption.AllDirectories);

        foreach (var filePath in existingFiles)
        {
            var fileInfo = new FileInfo(filePath);
            this.MoveFileIfContainsName(fileInfo, StartupProjectName, projectName);
        }
    }

    private void MoveFolderIfContainsName(DirectoryInfo folderInfo, string sourceName, string projectName)
    {
        if (folderInfo.Name.Contains(sourceName, StringComparison.Ordinal))
        {
            folderInfo.MoveTo(Path.Combine(folderInfo.Parent.FullName, folderInfo.Name.Replace(sourceName, projectName)));
        }
    }

    private void MoveFileIfContainsName(FileInfo fileInfo, string sourceName, string projectName)
    {
        if (fileInfo.Name.Contains(sourceName, StringComparison.Ordinal))
        {
            fileInfo.MoveTo(Path.Combine(fileInfo.Directory.FullName, fileInfo.Name.Replace(sourceName, projectName)));
        }
    }

    private string ModifyFileContent(string fileContent, string projectName)
    {
        string resultFileContent = fileContent;
        resultFileContent = resultFileContent.Replace(StartupProjectName, projectName);

        return resultFileContent;
    }

    private void ModifyFilesContent(string directory, string projectName)
    {
        var existingFiles = Directory.GetFiles(directory, "*", SearchOption.AllDirectories);

        foreach (var filePath in existingFiles)
        {
            string fileContent = File.ReadAllText(filePath);
            string modifiedFileContent = this.ModifyFileContent(fileContent, projectName);
            File.WriteAllText(filePath, modifiedFileContent);
        }
    }
}