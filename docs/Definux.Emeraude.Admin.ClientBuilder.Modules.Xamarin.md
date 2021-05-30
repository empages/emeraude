<a name='assembly'></a>
# Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin

## Contents

- [ClientBuilderOptionsExtensions](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-ClientBuilderOptionsExtensions 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions.ClientBuilderOptionsExtensions')
  - [AddDefaultXamarinModules(options)](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-ClientBuilderOptionsExtensions-AddDefaultXamarinModules-Definux-Emeraude-Admin-ClientBuilder-Options-ClientBuilderOptions- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions.ClientBuilderOptionsExtensions.AddDefaultXamarinModules(Definux.Emeraude.Admin.ClientBuilder.Options.ClientBuilderOptions)')
- [DtoTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplate.TransformText')
- [DtoTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.WriteLine(System.String,System.Object[])')
- [EndpointsExtensions](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-EndpointsExtensions 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions.EndpointsExtensions')
  - [GetBindableStrongTypedArgumentsListString(endpoint)](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-EndpointsExtensions-GetBindableStrongTypedArgumentsListString-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions.EndpointsExtensions.GetBindableStrongTypedArgumentsListString(Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint)')
  - [GetResponseBindableBuildTypeName(endpoint)](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-EndpointsExtensions-GetResponseBindableBuildTypeName-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions.EndpointsExtensions.GetResponseBindableBuildTypeName(Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint)')
  - [GetServiceAgentExecutionMethod(endpoint)](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-EndpointsExtensions-GetServiceAgentExecutionMethod-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions.EndpointsExtensions.GetServiceAgentExecutionMethod(Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint)')
- [EnumsTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplate.TransformText')
- [EnumsTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.WriteLine(System.String,System.Object[])')
- [Resources](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Resources 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Resources')
  - [Culture](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Resources-Culture 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Resources.Culture')
  - [ResourceManager](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Resources-ResourceManager 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Resources.ResourceManager')
  - [xamarin](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Resources-xamarin 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Resources.xamarin')
- [ServiceAgentClassTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplate.TransformText')
- [ServiceAgentClassTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.WriteLine(System.String,System.Object[])')
- [ServiceAgentInterfaceTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplate.TransformText')
- [ServiceAgentInterfaceTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.WriteLine(System.String,System.Object[])')
- [ServiceAgentsRegistratorTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplate.TransformText')
- [ServiceAgentsRegistratorTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.WriteLine(System.String,System.Object[])')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.ToStringInstanceHelper')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
- [TranslationsKeysTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplate.TransformText')
- [TranslationsKeysTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase.WriteLine(System.String,System.Object[])')
- [TranslationsTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplate.TransformText')
- [TranslationsTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase.WriteLine(System.String,System.Object[])')
- [TypeDescriptionsExtensions](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-TypeDescriptionsExtensions 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions.TypeDescriptionsExtensions')
  - [GetBindableBuildTypeName(typeDescription)](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-TypeDescriptionsExtensions-GetBindableBuildTypeName-Definux-Emeraude-Admin-ClientBuilder-Models-TypeDescription- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions.TypeDescriptionsExtensions.GetBindableBuildTypeName(Definux.Emeraude.Admin.ClientBuilder.Models.TypeDescription)')
- [XamarinAppFolders](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-XamarinAppFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.XamarinAppFolders')
  - [DataTransferObjects](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-XamarinAppFolders-DataTransferObjects 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.XamarinAppFolders.DataTransferObjects')
  - [ServiceAgents](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-XamarinAppFolders-ServiceAgents 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.XamarinAppFolders.ServiceAgents')
  - [Translations](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-XamarinAppFolders-Translations 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.XamarinAppFolders.Translations')
- [XamarinDataTransferObjectsModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-XamarinDataTransferObjectsModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.XamarinDataTransferObjectsModule')
  - [#ctor()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-XamarinDataTransferObjectsModule-#ctor 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.XamarinDataTransferObjectsModule.#ctor')
  - [DefineFiles()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-XamarinDataTransferObjectsModule-DefineFiles 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.XamarinDataTransferObjectsModule.DefineFiles')
  - [DefineFolders()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-XamarinDataTransferObjectsModule-DefineFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.XamarinDataTransferObjectsModule.DefineFolders')
- [XamarinScaffoldModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Abstractions-XamarinScaffoldModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions.XamarinScaffoldModule')
  - [#ctor(name,locked)](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Abstractions-XamarinScaffoldModule-#ctor-System-String,System-Boolean- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions.XamarinScaffoldModule.#ctor(System.String,System.Boolean)')
- [XamarinServiceAgentsModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-XamarinServiceAgentsModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.XamarinServiceAgentsModule')
  - [#ctor()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-XamarinServiceAgentsModule-#ctor 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.XamarinServiceAgentsModule.#ctor')
  - [DefineFiles()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-XamarinServiceAgentsModule-DefineFiles 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.XamarinServiceAgentsModule.DefineFiles')
  - [DefineFolders()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-XamarinServiceAgentsModule-DefineFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.XamarinServiceAgentsModule.DefineFolders')
- [XamarinTranslationsResourcesModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-XamarinTranslationsResourcesModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.XamarinTranslationsResourcesModule')
  - [#ctor()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-XamarinTranslationsResourcesModule-#ctor 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.XamarinTranslationsResourcesModule.#ctor')
  - [DefineFiles()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-XamarinTranslationsResourcesModule-DefineFiles 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.XamarinTranslationsResourcesModule.DefineFiles')
  - [DefineFolders()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-XamarinTranslationsResourcesModule-DefineFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.XamarinTranslationsResourcesModule.DefineFolders')

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-ClientBuilderOptionsExtensions'></a>
## ClientBuilderOptionsExtensions `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions

##### Summary

Extensions for [ClientBuilderOptions](#T-Definux-Emeraude-Admin-ClientBuilder-Options-ClientBuilderOptions 'Definux.Emeraude.Admin.ClientBuilder.Options.ClientBuilderOptions').

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-ClientBuilderOptionsExtensions-AddDefaultXamarinModules-Definux-Emeraude-Admin-ClientBuilder-Options-ClientBuilderOptions-'></a>
### AddDefaultXamarinModules(options) `method`

##### Summary

Add default build-in Xamarin Client Builder modules.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Definux.Emeraude.Admin.ClientBuilder.Options.ClientBuilderOptions](#T-Definux-Emeraude-Admin-ClientBuilder-Options-ClientBuilderOptions 'Definux.Emeraude.Admin.ClientBuilder.Options.ClientBuilderOptions') |  |

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplate'></a>
## DtoTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase'></a>
## DtoTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-EndpointsExtensions'></a>
## EndpointsExtensions `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions

##### Summary

Extensions for [Endpoint](#T-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint 'Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint').

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-EndpointsExtensions-GetBindableStrongTypedArgumentsListString-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint-'></a>
### GetBindableStrongTypedArgumentsListString(endpoint) `method`

##### Summary

Get arguments list as a string C# format for the current endpoint.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint](#T-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint 'Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint') |  |

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-EndpointsExtensions-GetResponseBindableBuildTypeName-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint-'></a>
### GetResponseBindableBuildTypeName(endpoint) `method`

##### Summary

Get response type as a string in C# format for the current endpoint.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint](#T-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint 'Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint') |  |

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-EndpointsExtensions-GetServiceAgentExecutionMethod-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint-'></a>
### GetServiceAgentExecutionMethod(endpoint) `method`

##### Summary

Get the name of the expected service agent name C# format for the current endpoint.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| endpoint | [Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint](#T-Definux-Emeraude-Admin-ClientBuilder-Models-Endpoint 'Definux.Emeraude.Admin.ClientBuilder.Models.Endpoint') |  |

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplate'></a>
## EnumsTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase'></a>
## EnumsTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Resources'></a>
## Resources `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Resources-xamarin'></a>
### xamarin `property`

##### Summary

Looks up a localized resource of type System.Byte[].

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplate'></a>
## ServiceAgentClassTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase'></a>
## ServiceAgentClassTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplate'></a>
## ServiceAgentInterfaceTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase'></a>
## ServiceAgentInterfaceTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplate'></a>
## ServiceAgentsRegistratorTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase'></a>
## ServiceAgentsRegistratorTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.DtoTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.Templates.EnumsTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentClassTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentInterfaceTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.Templates.ServiceAgentsRegistratorTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsKeysTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates.TranslationsTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-DtoTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-Templates-EnumsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentClassTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentInterfaceTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-Templates-ServiceAgentsRegistratorTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplate'></a>
## TranslationsKeysTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase'></a>
## TranslationsKeysTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsKeysTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplate'></a>
## TranslationsTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase'></a>
## TranslationsTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-Templates-TranslationsTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-TypeDescriptionsExtensions'></a>
## TypeDescriptionsExtensions `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Extensions

##### Summary

Extensions for [TypeDescription](#T-Definux-Emeraude-Admin-ClientBuilder-Models-TypeDescription 'Definux.Emeraude.Admin.ClientBuilder.Models.TypeDescription').

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Extensions-TypeDescriptionsExtensions-GetBindableBuildTypeName-Definux-Emeraude-Admin-ClientBuilder-Models-TypeDescription-'></a>
### GetBindableBuildTypeName(typeDescription) `method`

##### Summary

Gets bindable type of the current type description.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| typeDescription | [Definux.Emeraude.Admin.ClientBuilder.Models.TypeDescription](#T-Definux-Emeraude-Admin-ClientBuilder-Models-TypeDescription 'Definux.Emeraude.Admin.ClientBuilder.Models.TypeDescription') |  |

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-XamarinAppFolders'></a>
## XamarinAppFolders `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin

##### Summary

Default Xamarin generator result folders.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-XamarinAppFolders-DataTransferObjects'></a>
### DataTransferObjects `constants`

##### Summary

Data transfer objects.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-XamarinAppFolders-ServiceAgents'></a>
### ServiceAgents `constants`

##### Summary

Service agents.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-XamarinAppFolders-Translations'></a>
### Translations `constants`

##### Summary

Translations.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-XamarinDataTransferObjectsModule'></a>
## XamarinDataTransferObjectsModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects

##### Summary

Xamarin data transfer objects module for generation of all endpoints related objects needed for the consuming of the web API in Xamarin application.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-XamarinDataTransferObjectsModule-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [XamarinDataTransferObjectsModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-XamarinDataTransferObjectsModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.DataTransferObjects.XamarinDataTransferObjectsModule') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-XamarinDataTransferObjectsModule-DefineFiles'></a>
### DefineFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-DataTransferObjects-XamarinDataTransferObjectsModule-DefineFolders'></a>
### DefineFolders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Abstractions-XamarinScaffoldModule'></a>
## XamarinScaffoldModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions

##### Summary

Abstract Xamarin module for generation of files supporting Xamarin applications.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Abstractions-XamarinScaffoldModule-#ctor-System-String,System-Boolean-'></a>
### #ctor(name,locked) `constructor`

##### Summary

Initializes a new instance of the [XamarinScaffoldModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Abstractions-XamarinScaffoldModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Abstractions.XamarinScaffoldModule') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| locked | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-XamarinServiceAgentsModule'></a>
## XamarinServiceAgentsModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents

##### Summary

Xamarin service agents module for generation of all endpoints service agents for the consuming of the web API in Xamarin application.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-XamarinServiceAgentsModule-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [XamarinServiceAgentsModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-XamarinServiceAgentsModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.ServiceAgents.XamarinServiceAgentsModule') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-XamarinServiceAgentsModule-DefineFiles'></a>
### DefineFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-ServiceAgents-XamarinServiceAgentsModule-DefineFolders'></a>
### DefineFolders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-XamarinTranslationsResourcesModule'></a>
## XamarinTranslationsResourcesModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources

##### Summary

Xamarin translation resources module for generation of all localization resources based on localization context in Xamarin application.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-XamarinTranslationsResourcesModule-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [XamarinTranslationsResourcesModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-XamarinTranslationsResourcesModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Xamarin.Implementations.TranslationsResources.XamarinTranslationsResourcesModule') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-XamarinTranslationsResourcesModule-DefineFiles'></a>
### DefineFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Xamarin-Implementations-TranslationsResources-XamarinTranslationsResourcesModule-DefineFolders'></a>
### DefineFolders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
