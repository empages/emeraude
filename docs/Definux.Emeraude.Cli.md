<a name='assembly'></a>
# Definux.Emeraude.Cli

## Contents

- [ActionProvider](#T-Definux-Emeraude-Cli-ActionProvider 'Definux.Emeraude.Cli.ActionProvider')
  - [#ctor(args)](#M-Definux-Emeraude-Cli-ActionProvider-#ctor-System-String[]- 'Definux.Emeraude.Cli.ActionProvider.#ctor(System.String[])')
  - [Execute()](#M-Definux-Emeraude-Cli-ActionProvider-Execute 'Definux.Emeraude.Cli.ActionProvider.Execute')
- [BaseConfiguration](#T-Definux-Emeraude-Cli-CliConfig-BaseConfiguration 'Definux.Emeraude.Cli.CliConfig.BaseConfiguration')
  - [ProjectName](#P-Definux-Emeraude-Cli-CliConfig-BaseConfiguration-ProjectName 'Definux.Emeraude.Cli.CliConfig.BaseConfiguration.ProjectName')
- [CliConfig](#T-Definux-Emeraude-Cli-CliConfig 'Definux.Emeraude.Cli.CliConfig')
  - [#ctor()](#M-Definux-Emeraude-Cli-CliConfig-#ctor 'Definux.Emeraude.Cli.CliConfig.#ctor')
  - [FileName](#F-Definux-Emeraude-Cli-CliConfig-FileName 'Definux.Emeraude.Cli.CliConfig.FileName')
  - [Base](#P-Definux-Emeraude-Cli-CliConfig-Base 'Definux.Emeraude.Cli.CliConfig.Base')
- [Command](#T-Definux-Emeraude-Cli-Commands-Command 'Definux.Emeraude.Cli.Commands.Command')
  - [CliConfig](#P-Definux-Emeraude-Cli-Commands-Command-CliConfig 'Definux.Emeraude.Cli.Commands.Command.CliConfig')
  - [CliConfigDirectory](#P-Definux-Emeraude-Cli-Commands-Command-CliConfigDirectory 'Definux.Emeraude.Cli.Commands.Command.CliConfigDirectory')
  - [Execute(parameters)](#M-Definux-Emeraude-Cli-Commands-Command-Execute-System-Collections-Generic-Dictionary{System-String,System-String}- 'Definux.Emeraude.Cli.Commands.Command.Execute(System.Collections.Generic.Dictionary{System.String,System.String})')
  - [LoadCliConfig(configurationDirectory)](#M-Definux-Emeraude-Cli-Commands-Command-LoadCliConfig-System-String- 'Definux.Emeraude.Cli.Commands.Command.LoadCliConfig(System.String)')
- [CommandParameters](#T-Definux-Emeraude-Cli-Commands-CommandParameters 'Definux.Emeraude.Cli.Commands.CommandParameters')
  - [ConfigurationDirectory](#F-Definux-Emeraude-Cli-Commands-CommandParameters-ConfigurationDirectory 'Definux.Emeraude.Cli.Commands.CommandParameters.ConfigurationDirectory')
  - [Name](#F-Definux-Emeraude-Cli-Commands-CommandParameters-Name 'Definux.Emeraude.Cli.Commands.CommandParameters.Name')
- [CommandTemplate](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplate 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplate')
  - [TransformText()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplate-TransformText 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplate.TransformText')
- [CommandTemplateBase](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-CurrentIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Errors 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-GenerationEnvironment 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Session 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ToStringHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-indentLengths 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ClearIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Error-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-PopIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Warning-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Write-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.WriteLine(System.String,System.Object[])')
- [CommandValidatorTemplate](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplate 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplate')
  - [TransformText()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplate-TransformText 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplate.TransformText')
- [CommandValidatorTemplateBase](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-CurrentIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Errors 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-GenerationEnvironment 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Session 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ToStringHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-indentLengths 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ClearIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Error-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-PopIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Warning-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Write-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.WriteLine(System.String,System.Object[])')
- [CommandsNames](#T-Definux-Emeraude-Cli-Commands-CommandsNames 'Definux.Emeraude.Cli.Commands.CommandsNames')
  - [CommandList](#F-Definux-Emeraude-Cli-Commands-CommandsNames-CommandList 'Definux.Emeraude.Cli.Commands.CommandsNames.CommandList')
  - [Create](#F-Definux-Emeraude-Cli-Commands-CommandsNames-Create 'Definux.Emeraude.Cli.Commands.CommandsNames.Create')
  - [Help](#F-Definux-Emeraude-Cli-Commands-CommandsNames-Help 'Definux.Emeraude.Cli.Commands.CommandsNames.Help')
  - [Request](#F-Definux-Emeraude-Cli-Commands-CommandsNames-Request 'Definux.Emeraude.Cli.Commands.CommandsNames.Request')
- [ConsoleCommand](#T-Definux-Emeraude-Cli-Commands-ConsoleCommand 'Definux.Emeraude.Cli.Commands.ConsoleCommand')
  - [#ctor(commandArgs)](#M-Definux-Emeraude-Cli-Commands-ConsoleCommand-#ctor-System-String[]- 'Definux.Emeraude.Cli.Commands.ConsoleCommand.#ctor(System.String[])')
  - [Command](#P-Definux-Emeraude-Cli-Commands-ConsoleCommand-Command 'Definux.Emeraude.Cli.Commands.ConsoleCommand.Command')
  - [IsValid](#P-Definux-Emeraude-Cli-Commands-ConsoleCommand-IsValid 'Definux.Emeraude.Cli.Commands.ConsoleCommand.IsValid')
  - [Parameters](#P-Definux-Emeraude-Cli-Commands-ConsoleCommand-Parameters 'Definux.Emeraude.Cli.Commands.ConsoleCommand.Parameters')
  - [GetParameter(name)](#M-Definux-Emeraude-Cli-Commands-ConsoleCommand-GetParameter-System-String- 'Definux.Emeraude.Cli.Commands.ConsoleCommand.GetParameter(System.String)')
- [Constants](#T-Definux-Emeraude-Cli-Constants 'Definux.Emeraude.Cli.Constants')
  - [SourceFolder](#F-Definux-Emeraude-Cli-Constants-SourceFolder 'Definux.Emeraude.Cli.Constants.SourceFolder')
- [CreateCommand](#T-Definux-Emeraude-Cli-Commands-Implementations-Create-CreateCommand 'Definux.Emeraude.Cli.Commands.Implementations.Create.CreateCommand')
  - [Execute()](#M-Definux-Emeraude-Cli-Commands-Implementations-Create-CreateCommand-Execute-System-Collections-Generic-Dictionary{System-String,System-String}- 'Definux.Emeraude.Cli.Commands.Implementations.Create.CreateCommand.Execute(System.Collections.Generic.Dictionary{System.String,System.String})')
- [Messages](#T-Definux-Emeraude-Cli-Properties-Messages 'Definux.Emeraude.Cli.Properties.Messages')
  - [CliFileFound](#P-Definux-Emeraude-Cli-Properties-Messages-CliFileFound 'Definux.Emeraude.Cli.Properties.Messages.CliFileFound')
  - [CliFileNotFound](#P-Definux-Emeraude-Cli-Properties-Messages-CliFileNotFound 'Definux.Emeraude.Cli.Properties.Messages.CliFileNotFound')
  - [CommandSuccessfullyCreated](#P-Definux-Emeraude-Cli-Properties-Messages-CommandSuccessfullyCreated 'Definux.Emeraude.Cli.Properties.Messages.CommandSuccessfullyCreated')
  - [Culture](#P-Definux-Emeraude-Cli-Properties-Messages-Culture 'Definux.Emeraude.Cli.Properties.Messages.Culture')
  - [FileExistMessage](#P-Definux-Emeraude-Cli-Properties-Messages-FileExistMessage 'Definux.Emeraude.Cli.Properties.Messages.FileExistMessage')
  - [InvalidCliCommandUsage](#P-Definux-Emeraude-Cli-Properties-Messages-InvalidCliCommandUsage 'Definux.Emeraude.Cli.Properties.Messages.InvalidCliCommandUsage')
  - [InvalidRequestCommand](#P-Definux-Emeraude-Cli-Properties-Messages-InvalidRequestCommand 'Definux.Emeraude.Cli.Properties.Messages.InvalidRequestCommand')
  - [MissedCliConfigFile](#P-Definux-Emeraude-Cli-Properties-Messages-MissedCliConfigFile 'Definux.Emeraude.Cli.Properties.Messages.MissedCliConfigFile')
  - [PageSuccessfullyCreated](#P-Definux-Emeraude-Cli-Properties-Messages-PageSuccessfullyCreated 'Definux.Emeraude.Cli.Properties.Messages.PageSuccessfullyCreated')
  - [ProjectRequiresAName](#P-Definux-Emeraude-Cli-Properties-Messages-ProjectRequiresAName 'Definux.Emeraude.Cli.Properties.Messages.ProjectRequiresAName')
  - [ProjectSuccessfullyCreated](#P-Definux-Emeraude-Cli-Properties-Messages-ProjectSuccessfullyCreated 'Definux.Emeraude.Cli.Properties.Messages.ProjectSuccessfullyCreated')
  - [QuerySuccessfullyCreated](#P-Definux-Emeraude-Cli-Properties-Messages-QuerySuccessfullyCreated 'Definux.Emeraude.Cli.Properties.Messages.QuerySuccessfullyCreated')
  - [RequestCannotBeCreated](#P-Definux-Emeraude-Cli-Properties-Messages-RequestCannotBeCreated 'Definux.Emeraude.Cli.Properties.Messages.RequestCannotBeCreated')
  - [ResourceManager](#P-Definux-Emeraude-Cli-Properties-Messages-ResourceManager 'Definux.Emeraude.Cli.Properties.Messages.ResourceManager')
  - [SeeHelpForCli](#P-Definux-Emeraude-Cli-Properties-Messages-SeeHelpForCli 'Definux.Emeraude.Cli.Properties.Messages.SeeHelpForCli')
  - [SomethingUnexpectedHappened](#P-Definux-Emeraude-Cli-Properties-Messages-SomethingUnexpectedHappened 'Definux.Emeraude.Cli.Properties.Messages.SomethingUnexpectedHappened')
- [Program](#T-Definux-Emeraude-Cli-Program 'Definux.Emeraude.Cli.Program')
  - [Main(args)](#M-Definux-Emeraude-Cli-Program-Main-System-String[]- 'Definux.Emeraude.Cli.Program.Main(System.String[])')
- [QueryTemplate](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplate 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplate')
  - [TransformText()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplate-TransformText 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplate.TransformText')
- [QueryTemplateBase](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-CurrentIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Errors 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-GenerationEnvironment 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Session 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ToStringHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-indentLengths 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ClearIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Error-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-PopIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Warning-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Write-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.WriteLine(System.String,System.Object[])')
- [RequestCommand](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-RequestCommand 'Definux.Emeraude.Cli.Commands.Implementations.Request.RequestCommand')
  - [Execute()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-RequestCommand-Execute-System-Collections-Generic-Dictionary{System-String,System-String}- 'Definux.Emeraude.Cli.Commands.Implementations.Request.RequestCommand.Execute(System.Collections.Generic.Dictionary{System.String,System.String})')
- [RequestTemplate](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplate 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplate')
  - [TransformText()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplate-TransformText 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplate.TransformText')
- [RequestTemplateBase](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-CurrentIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Errors 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-GenerationEnvironment 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Session 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ToStringHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-indentLengths 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ClearIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Error-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-PopIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Warning-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Write-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.WriteLine(System.String,System.Object[])')
- [ResultTemplate](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplate 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplate')
  - [TransformText()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplate-TransformText 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplate.TransformText')
- [ResultTemplateBase](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-CurrentIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Errors 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-GenerationEnvironment 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Session 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ToStringHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-indentLengths 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ClearIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Error-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-PopIndent 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Warning-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Write-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.WriteLine(System.String,System.Object[])')
- [StaticConsolePrints](#T-Definux-Emeraude-Cli-StaticConsolePrints 'Definux.Emeraude.Cli.StaticConsolePrints')
  - [PrintGeneralInformation()](#M-Definux-Emeraude-Cli-StaticConsolePrints-PrintGeneralInformation 'Definux.Emeraude.Cli.StaticConsolePrints.PrintGeneralInformation')
  - [PrintHelpInformation()](#M-Definux-Emeraude-Cli-StaticConsolePrints-PrintHelpInformation 'Definux.Emeraude.Cli.StaticConsolePrints.PrintHelpInformation')
- [TemplateRenderer](#T-Definux-Emeraude-Cli-Commands-TemplateRenderer 'Definux.Emeraude.Cli.Commands.TemplateRenderer')
  - [RenderTemplate(templateType,sessionDictionary)](#M-Definux-Emeraude-Cli-Commands-TemplateRenderer-RenderTemplate-System-Type,System-Collections-Generic-Dictionary{System-String,System-Object}- 'Definux.Emeraude.Cli.Commands.TemplateRenderer.RenderTemplate(System.Type,System.Collections.Generic.Dictionary{System.String,System.Object})')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.ToStringInstanceHelper')
  - [FormatProvider](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
- [Utilities](#T-Definux-Emeraude-Cli-Utilities 'Definux.Emeraude.Cli.Utilities')
  - [RecursiveDelete(directory)](#M-Definux-Emeraude-Cli-Utilities-RecursiveDelete-System-IO-DirectoryInfo- 'Definux.Emeraude.Cli.Utilities.RecursiveDelete(System.IO.DirectoryInfo)')

<a name='T-Definux-Emeraude-Cli-ActionProvider'></a>
## ActionProvider `type`

##### Namespace

Definux.Emeraude.Cli

##### Summary

Command factory provider that contains and triggers the command execution.

<a name='M-Definux-Emeraude-Cli-ActionProvider-#ctor-System-String[]-'></a>
### #ctor(args) `constructor`

##### Summary

Initializes a new instance of the [ActionProvider](#T-Definux-Emeraude-Cli-ActionProvider 'Definux.Emeraude.Cli.ActionProvider') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='M-Definux-Emeraude-Cli-ActionProvider-Execute'></a>
### Execute() `method`

##### Summary

Parse and executes the inputed command.

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-CliConfig-BaseConfiguration'></a>
## BaseConfiguration `type`

##### Namespace

Definux.Emeraude.Cli.CliConfig

##### Summary

Configuration base section.

<a name='P-Definux-Emeraude-Cli-CliConfig-BaseConfiguration-ProjectName'></a>
### ProjectName `property`

##### Summary

Name of the project.

<a name='T-Definux-Emeraude-Cli-CliConfig'></a>
## CliConfig `type`

##### Namespace

Definux.Emeraude.Cli

##### Summary

Implementation of CLI configuration.

<a name='M-Definux-Emeraude-Cli-CliConfig-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [CliConfig](#T-Definux-Emeraude-Cli-CliConfig 'Definux.Emeraude.Cli.CliConfig') class.

##### Parameters

This constructor has no parameters.

<a name='F-Definux-Emeraude-Cli-CliConfig-FileName'></a>
### FileName `constants`

##### Summary

Name of the Emeraude CLI configuration.

<a name='P-Definux-Emeraude-Cli-CliConfig-Base'></a>
### Base `property`

##### Summary

*Inherit from parent.*

<a name='T-Definux-Emeraude-Cli-Commands-Command'></a>
## Command `type`

##### Namespace

Definux.Emeraude.Cli.Commands

##### Summary

Abstract implementation of CLI command factory.

<a name='P-Definux-Emeraude-Cli-Commands-Command-CliConfig'></a>
### CliConfig `property`

##### Summary

[CliConfig](#T-Definux-Emeraude-Cli-CliConfig 'Definux.Emeraude.Cli.CliConfig').

<a name='P-Definux-Emeraude-Cli-Commands-Command-CliConfigDirectory'></a>
### CliConfigDirectory `property`

##### Summary

Directory where the CLI configuration is placed.

<a name='M-Definux-Emeraude-Cli-Commands-Command-Execute-System-Collections-Generic-Dictionary{System-String,System-String}-'></a>
### Execute(parameters) `method`

##### Summary

Executes the command generation.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| parameters | [System.Collections.Generic.Dictionary{System.String,System.String}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.String}') |  |

<a name='M-Definux-Emeraude-Cli-Commands-Command-LoadCliConfig-System-String-'></a>
### LoadCliConfig(configurationDirectory) `method`

##### Summary

Loads and parse the CLI configuration file.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| configurationDirectory | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Cli-Commands-CommandParameters'></a>
## CommandParameters `type`

##### Namespace

Definux.Emeraude.Cli.Commands

##### Summary

List of all commands parameters aliases.

<a name='F-Definux-Emeraude-Cli-Commands-CommandParameters-ConfigurationDirectory'></a>
### ConfigurationDirectory `constants`

##### Summary

Alias for 'ConfigurationDirectory'.

<a name='F-Definux-Emeraude-Cli-Commands-CommandParameters-Name'></a>
### Name `constants`

##### Summary

Alias for 'Name'.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplate'></a>
## CommandTemplate `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase'></a>
## CommandTemplateBase `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplate'></a>
## CommandValidatorTemplate `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase'></a>
## CommandValidatorTemplateBase `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-CommandsNames'></a>
## CommandsNames `type`

##### Namespace

Definux.Emeraude.Cli.Commands

##### Summary

Commands names provider class.

<a name='F-Definux-Emeraude-Cli-Commands-CommandsNames-CommandList'></a>
### CommandList `constants`

##### Summary

List of all commands names.

<a name='F-Definux-Emeraude-Cli-Commands-CommandsNames-Create'></a>
### Create `constants`

##### Summary

Name of the 'Create' command.

<a name='F-Definux-Emeraude-Cli-Commands-CommandsNames-Help'></a>
### Help `constants`

##### Summary

Name of the 'Help' command.

<a name='F-Definux-Emeraude-Cli-Commands-CommandsNames-Request'></a>
### Request `constants`

##### Summary

Name of the 'Request' command.

<a name='T-Definux-Emeraude-Cli-Commands-ConsoleCommand'></a>
## ConsoleCommand `type`

##### Namespace

Definux.Emeraude.Cli.Commands

##### Summary

Mapping class that parse the command string.

<a name='M-Definux-Emeraude-Cli-Commands-ConsoleCommand-#ctor-System-String[]-'></a>
### #ctor(commandArgs) `constructor`

##### Summary

Initializes a new instance of the [ConsoleCommand](#T-Definux-Emeraude-Cli-Commands-ConsoleCommand 'Definux.Emeraude.Cli.Commands.ConsoleCommand') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| commandArgs | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='P-Definux-Emeraude-Cli-Commands-ConsoleCommand-Command'></a>
### Command `property`

##### Summary

Command string.

<a name='P-Definux-Emeraude-Cli-Commands-ConsoleCommand-IsValid'></a>
### IsValid `property`

##### Summary

Indicates whether the command is valid or not.

<a name='P-Definux-Emeraude-Cli-Commands-ConsoleCommand-Parameters'></a>
### Parameters `property`

##### Summary

Parameters of the command.

<a name='M-Definux-Emeraude-Cli-Commands-ConsoleCommand-GetParameter-System-String-'></a>
### GetParameter(name) `method`

##### Summary

Get command parameter by name.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Cli-Constants'></a>
## Constants `type`

##### Namespace

Definux.Emeraude.Cli

##### Summary

Emeraude CLI constants.

<a name='F-Definux-Emeraude-Cli-Constants-SourceFolder'></a>
### SourceFolder `constants`

##### Summary

Name of the source folder for project.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Create-CreateCommand'></a>
## CreateCommand `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Create

##### Summary

Command for creating the startup project.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Create-CreateCommand-Execute-System-Collections-Generic-Dictionary{System-String,System-String}-'></a>
### Execute() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Properties-Messages'></a>
## Messages `type`

##### Namespace

Definux.Emeraude.Cli.Properties

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Definux-Emeraude-Cli-Properties-Messages-CliFileFound'></a>
### CliFileFound `property`

##### Summary

Looks up a localized string similar to CLI configuration file has been found..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-CliFileNotFound'></a>
### CliFileNotFound `property`

##### Summary

Looks up a localized string similar to CLI configuration file has not been found..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-CommandSuccessfullyCreated'></a>
### CommandSuccessfullyCreated `property`

##### Summary

Looks up a localized string similar to Command has been created successfully..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Definux-Emeraude-Cli-Properties-Messages-FileExistMessage'></a>
### FileExistMessage `property`

##### Summary

Looks up a localized string similar to One or more of the files already exist. Overriding is not possible for safety reasons..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-InvalidCliCommandUsage'></a>
### InvalidCliCommandUsage `property`

##### Summary

Looks up a localized string similar to Invalid usage of CLI command..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-InvalidRequestCommand'></a>
### InvalidRequestCommand `property`

##### Summary

Looks up a localized string similar to Request name must ends with Query or Command - example: GetSomethingQuery or MakeSomethingCommand.

<a name='P-Definux-Emeraude-Cli-Properties-Messages-MissedCliConfigFile'></a>
### MissedCliConfigFile `property`

##### Summary

Looks up a localized string similar to CLI configuration file cannot be found. Be sure you execute the command in the 'em-cli.json' directory..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-PageSuccessfullyCreated'></a>
### PageSuccessfullyCreated `property`

##### Summary

Looks up a localized string similar to Page has been created successfully..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-ProjectRequiresAName'></a>
### ProjectRequiresAName `property`

##### Summary

Looks up a localized string similar to Project initialization requires project name parameter..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-ProjectSuccessfullyCreated'></a>
### ProjectSuccessfullyCreated `property`

##### Summary

Looks up a localized string similar to Project structure has been successfully created..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-QuerySuccessfullyCreated'></a>
### QuerySuccessfullyCreated `property`

##### Summary

Looks up a localized string similar to Query has been created successfully..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-RequestCannotBeCreated'></a>
### RequestCannotBeCreated `property`

##### Summary

Looks up a localized string similar to Request cannot be created..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Definux-Emeraude-Cli-Properties-Messages-SeeHelpForCli'></a>
### SeeHelpForCli `property`

##### Summary

Looks up a localized string similar to Type 'em' to check available commands..

<a name='P-Definux-Emeraude-Cli-Properties-Messages-SomethingUnexpectedHappened'></a>
### SomethingUnexpectedHappened `property`

##### Summary

Looks up a localized string similar to Something unexpected happened. :(.

<a name='T-Definux-Emeraude-Cli-Program'></a>
## Program `type`

##### Namespace

Definux.Emeraude.Cli

##### Summary

Startup class of the CLI.

<a name='M-Definux-Emeraude-Cli-Program-Main-System-String[]-'></a>
### Main(args) `method`

##### Summary

Startup method of the CLI.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| args | [System.String[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String[] 'System.String[]') |  |

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplate'></a>
## QueryTemplate `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase'></a>
## QueryTemplateBase `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-RequestCommand'></a>
## RequestCommand `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request

##### Summary

Command for creating a new request (query or comment).

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-RequestCommand-Execute-System-Collections-Generic-Dictionary{System-String,System-String}-'></a>
### Execute() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplate'></a>
## RequestTemplate `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase'></a>
## RequestTemplateBase `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplate'></a>
## ResultTemplate `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase'></a>
## ResultTemplateBase `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-StaticConsolePrints'></a>
## StaticConsolePrints `type`

##### Namespace

Definux.Emeraude.Cli

##### Summary

Static strings for console prints.

<a name='M-Definux-Emeraude-Cli-StaticConsolePrints-PrintGeneralInformation'></a>
### PrintGeneralInformation() `method`

##### Summary

Prints the general information of the CLI.

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-StaticConsolePrints-PrintHelpInformation'></a>
### PrintHelpInformation() `method`

##### Summary

Prints the help information of the CLI.

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Commands-TemplateRenderer'></a>
## TemplateRenderer `type`

##### Namespace

Definux.Emeraude.Cli.Commands

##### Summary

Template renderer for T4 templates.

<a name='M-Definux-Emeraude-Cli-Commands-TemplateRenderer-RenderTemplate-System-Type,System-Collections-Generic-Dictionary{System-String,System-Object}-'></a>
### RenderTemplate(templateType,sessionDictionary) `method`

##### Summary

Render T4 template by its assembly type.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| templateType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') |  |
| sessionDictionary | [System.Collections.Generic.Dictionary{System.String,System.Object}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.Dictionary 'System.Collections.Generic.Dictionary{System.String,System.Object}') |  |

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.CommandValidatorTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.QueryTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.RequestTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Cli.Commands.Implementations.Request.Templates.ResultTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-CommandValidatorTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-QueryTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-RequestTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Cli-Commands-Implementations-Request-Templates-ResultTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Cli-Utilities'></a>
## Utilities `type`

##### Namespace

Definux.Emeraude.Cli

##### Summary

Utility functions.

<a name='M-Definux-Emeraude-Cli-Utilities-RecursiveDelete-System-IO-DirectoryInfo-'></a>
### RecursiveDelete(directory) `method`

##### Summary

Deletes folders recursively.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| directory | [System.IO.DirectoryInfo](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryInfo 'System.IO.DirectoryInfo') |  |
