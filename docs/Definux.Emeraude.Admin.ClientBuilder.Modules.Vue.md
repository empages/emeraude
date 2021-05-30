<a name='assembly'></a>
# Definux.Emeraude.Admin.ClientBuilder.Modules.Vue

## Contents

- [ClientBuilderOptionsExtensions](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Extensions-ClientBuilderOptionsExtensions 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Extensions.ClientBuilderOptionsExtensions')
  - [AddDefaultVueModules(options)](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Extensions-ClientBuilderOptionsExtensions-AddDefaultVueModules-Definux-Emeraude-Admin-ClientBuilder-Options-ClientBuilderOptions- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Extensions.ClientBuilderOptionsExtensions.AddDefaultVueModules(Definux.Emeraude.Admin.ClientBuilder.Options.ClientBuilderOptions)')
- [ComponentTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplate.TransformText')
- [ComponentTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.WriteLine(System.String,System.Object[])')
- [ConstantsTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplate.TransformText')
- [ConstantsTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.WriteLine(System.String,System.Object[])')
- [EndpointsTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplate.TransformText')
- [EndpointsTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.WriteLine(System.String,System.Object[])')
- [EnumsTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplate.TransformText')
- [EnumsTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.WriteLine(System.String,System.Object[])')
- [I18nConfigTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplate.TransformText')
- [I18nConfigTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.WriteLine(System.String,System.Object[])')
- [Resources](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Resources 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Resources')
  - [Culture](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Resources-Culture 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Resources.Culture')
  - [ResourceManager](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Resources-ResourceManager 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Resources.ResourceManager')
  - [vuejs](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Resources-vuejs 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Resources.vuejs')
- [RoutesTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplate.TransformText')
- [RoutesTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.WriteLine(System.String,System.Object[])')
- [StaticContentComponentTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplate.TransformText')
- [StaticContentComponentTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.WriteLine(System.String,System.Object[])')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.ToStringInstanceHelper')
- [ToStringInstanceHelper](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ToStringInstanceHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.ToStringInstanceHelper')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [FormatProvider](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ToStringInstanceHelper-FormatProvider 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.ToStringInstanceHelper.FormatProvider')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
  - [ToStringWithCulture()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.ToStringInstanceHelper.ToStringWithCulture(System.Object)')
- [TypesTemplate](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplate 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplate')
  - [TransformText()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplate-TransformText 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplate.TransformText')
- [TypesTemplateBase](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase')
  - [CurrentIndent](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-CurrentIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.CurrentIndent')
  - [Errors](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Errors 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.Errors')
  - [GenerationEnvironment](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-GenerationEnvironment 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.GenerationEnvironment')
  - [Session](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Session 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.Session')
  - [ToStringHelper](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ToStringHelper 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.ToStringHelper')
  - [indentLengths](#P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-indentLengths 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.indentLengths')
  - [ClearIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ClearIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.ClearIndent')
  - [Error()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Error-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.Error(System.String)')
  - [PopIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-PopIndent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.PopIndent')
  - [PushIndent()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-PushIndent-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.PushIndent(System.String)')
  - [Warning()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Warning-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.Warning(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Write-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.Write(System.String)')
  - [Write()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Write-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.Write(System.String,System.Object[])')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-WriteLine-System-String- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.WriteLine(System.String)')
  - [WriteLine()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-WriteLine-System-String,System-Object[]- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase.WriteLine(System.String,System.Object[])')
- [VueAppFolders](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.VueAppFolders')
  - [Api](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Api 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.VueAppFolders.Api')
  - [ClientApp](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-ClientApp 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.VueAppFolders.ClientApp')
  - [Components](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Components 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.VueAppFolders.Components')
  - [Locales](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Locales 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.VueAppFolders.Locales')
  - [Pages](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Pages 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.VueAppFolders.Pages')
  - [Router](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Router 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.VueAppFolders.Router')
  - [Shared](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Shared 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.VueAppFolders.Shared')
  - [StaticContent](#F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-StaticContent 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.VueAppFolders.StaticContent')
- [VueConstantsModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-VueConstantsModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.VueConstantsModule')
  - [#ctor()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-VueConstantsModule-#ctor 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.VueConstantsModule.#ctor')
  - [DefineFiles()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-VueConstantsModule-DefineFiles 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.VueConstantsModule.DefineFiles')
  - [DefineFolders()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-VueConstantsModule-DefineFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.VueConstantsModule.DefineFolders')
- [VueEmPagesModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-VueEmPagesModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.VueEmPagesModule')
  - [#ctor()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-VueEmPagesModule-#ctor 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.VueEmPagesModule.#ctor')
  - [DefineFiles()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-VueEmPagesModule-DefineFiles 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.VueEmPagesModule.DefineFiles')
  - [DefineFolders()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-VueEmPagesModule-DefineFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.VueEmPagesModule.DefineFolders')
- [VueRoutesModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-VueRoutesModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.VueRoutesModule')
  - [#ctor()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-VueRoutesModule-#ctor 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.VueRoutesModule.#ctor')
  - [DefineFiles()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-VueRoutesModule-DefineFiles 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.VueRoutesModule.DefineFiles')
  - [DefineFolders()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-VueRoutesModule-DefineFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.VueRoutesModule.DefineFolders')
- [VueScaffoldModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Abstractions-VueScaffoldModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions.VueScaffoldModule')
  - [#ctor(name,locked)](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Abstractions-VueScaffoldModule-#ctor-System-String,System-Boolean- 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions.VueScaffoldModule.#ctor(System.String,System.Boolean)')
- [VueStaticContentModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-VueStaticContentModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.VueStaticContentModule')
  - [#ctor()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-VueStaticContentModule-#ctor 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.VueStaticContentModule.#ctor')
  - [DefineFiles()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-VueStaticContentModule-DefineFiles 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.VueStaticContentModule.DefineFiles')
  - [DefineFolders()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-VueStaticContentModule-DefineFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.VueStaticContentModule.DefineFolders')
- [VueTranslationsResourcesModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-VueTranslationsResourcesModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.VueTranslationsResourcesModule')
  - [#ctor()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-VueTranslationsResourcesModule-#ctor 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.VueTranslationsResourcesModule.#ctor')
  - [DefineFiles()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-VueTranslationsResourcesModule-DefineFiles 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.VueTranslationsResourcesModule.DefineFiles')
  - [DefineFolders()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-VueTranslationsResourcesModule-DefineFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.VueTranslationsResourcesModule.DefineFolders')
- [VueWebApiModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-VueWebApiModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.VueWebApiModule')
  - [#ctor()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-VueWebApiModule-#ctor 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.VueWebApiModule.#ctor')
  - [DefineFiles()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-VueWebApiModule-DefineFiles 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.VueWebApiModule.DefineFiles')
  - [DefineFolders()](#M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-VueWebApiModule-DefineFolders 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.VueWebApiModule.DefineFolders')

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Extensions-ClientBuilderOptionsExtensions'></a>
## ClientBuilderOptionsExtensions `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Extensions

##### Summary

Extensions for [ClientBuilderOptions](#T-Definux-Emeraude-Admin-ClientBuilder-Options-ClientBuilderOptions 'Definux.Emeraude.Admin.ClientBuilder.Options.ClientBuilderOptions').

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Extensions-ClientBuilderOptionsExtensions-AddDefaultVueModules-Definux-Emeraude-Admin-ClientBuilder-Options-ClientBuilderOptions-'></a>
### AddDefaultVueModules(options) `method`

##### Summary

Add default Vue modules.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| options | [Definux.Emeraude.Admin.ClientBuilder.Options.ClientBuilderOptions](#T-Definux-Emeraude-Admin-ClientBuilder-Options-ClientBuilderOptions 'Definux.Emeraude.Admin.ClientBuilder.Options.ClientBuilderOptions') |  |

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplate'></a>
## ComponentTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase'></a>
## ComponentTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplate'></a>
## ConstantsTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase'></a>
## ConstantsTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplate'></a>
## EndpointsTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase'></a>
## EndpointsTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplate'></a>
## EnumsTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase'></a>
## EnumsTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplate'></a>
## I18nConfigTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase'></a>
## I18nConfigTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Resources'></a>
## Resources `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue

##### Summary

A strongly-typed resource class, for looking up localized strings, etc.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Resources-Culture'></a>
### Culture `property`

##### Summary

Overrides the current thread's CurrentUICulture property for all
  resource lookups using this strongly typed resource class.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Resources-ResourceManager'></a>
### ResourceManager `property`

##### Summary

Returns the cached ResourceManager instance used by this class.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Resources-vuejs'></a>
### vuejs `property`

##### Summary

Looks up a localized resource of type System.Byte[].

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplate'></a>
## RoutesTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase'></a>
## RoutesTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplate'></a>
## StaticContentComponentTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase'></a>
## StaticContentComponentTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.Templates.ConstantsTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.Templates.ComponentTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.Templates.RoutesTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.Templates.StaticContentComponentTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.Templates.I18nConfigTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EndpointsTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.EnumsTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ToStringInstanceHelper'></a>
## ToStringInstanceHelper `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates.TypesTemplateBase

##### Summary

Utility class to produce culture-oriented representation of an object as a string.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ToStringInstanceHelper-FormatProvider'></a>
### FormatProvider `property`

##### Summary

Gets or sets format provider to be used by ToStringWithCulture method.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-Templates-ConstantsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-Templates-ComponentTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-Templates-RoutesTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-Templates-StaticContentComponentTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-Templates-I18nConfigTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EndpointsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-EnumsTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ToStringInstanceHelper-ToStringWithCulture-System-Object-'></a>
### ToStringWithCulture() `method`

##### Summary

This is called from the compile/run appdomain to convert objects within an expression block to a string

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplate'></a>
## TypesTemplate `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates

##### Summary

Class to produce the template output

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplate-TransformText'></a>
### TransformText() `method`

##### Summary

Create the template output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase'></a>
## TypesTemplateBase `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.Templates

##### Summary

Base class for this transformation

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-CurrentIndent'></a>
### CurrentIndent `property`

##### Summary

Gets the current indent we use when adding lines to the output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Errors'></a>
### Errors `property`

##### Summary

The error collection for the generation process

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-GenerationEnvironment'></a>
### GenerationEnvironment `property`

##### Summary

The string builder that generation-time code is using to assemble generated output

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Session'></a>
### Session `property`

##### Summary

Current transformation session

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ToStringHelper'></a>
### ToStringHelper `property`

##### Summary

Helper to produce culture-oriented representation of an object as a string

<a name='P-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-indentLengths'></a>
### indentLengths `property`

##### Summary

A list of the lengths of each indent that was added with PushIndent

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-ClearIndent'></a>
### ClearIndent() `method`

##### Summary

Remove any indentation

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Error-System-String-'></a>
### Error() `method`

##### Summary

Raise an error

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-PopIndent'></a>
### PopIndent() `method`

##### Summary

Remove the last indent that was added with PushIndent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-PushIndent-System-String-'></a>
### PushIndent() `method`

##### Summary

Increase the indent

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Warning-System-String-'></a>
### Warning() `method`

##### Summary

Raise a warning

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Write-System-String-'></a>
### Write() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-Write-System-String,System-Object[]-'></a>
### Write() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-WriteLine-System-String-'></a>
### WriteLine() `method`

##### Summary

Write text directly into the generated output

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-Templates-TypesTemplateBase-WriteLine-System-String,System-Object[]-'></a>
### WriteLine() `method`

##### Summary

Write formatted text directly into the generated output

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders'></a>
## VueAppFolders `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue

##### Summary

Folder names from Vue modules.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Api'></a>
### Api `constants`

##### Summary

Api folder name.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-ClientApp'></a>
### ClientApp `constants`

##### Summary

ClientApp folder name.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Components'></a>
### Components `constants`

##### Summary

Components folder name.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Locales'></a>
### Locales `constants`

##### Summary

Locales folder name.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Pages'></a>
### Pages `constants`

##### Summary

Pages folder name.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Router'></a>
### Router `constants`

##### Summary

Router folder name.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-Shared'></a>
### Shared `constants`

##### Summary

Shared folder name.

<a name='F-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-VueAppFolders-StaticContent'></a>
### StaticContent `constants`

##### Summary

StaticContent folder name.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-VueConstantsModule'></a>
## VueConstantsModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants

##### Summary

Vue constants module for generation constants values for transfer data from back-end to front-end.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-VueConstantsModule-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [VueConstantsModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-VueConstantsModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Constants.VueConstantsModule') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-VueConstantsModule-DefineFiles'></a>
### DefineFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Constants-VueConstantsModule-DefineFolders'></a>
### DefineFolders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-VueEmPagesModule'></a>
## VueEmPagesModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages

##### Summary

Vue EmPages module for generation of all pages components for created EmPages in Vue application.
The generation of this module is executing once in case when the page does not exist.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-VueEmPagesModule-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [VueEmPagesModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-VueEmPagesModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.EmPages.VueEmPagesModule') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-VueEmPagesModule-DefineFiles'></a>
### DefineFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-EmPages-VueEmPagesModule-DefineFolders'></a>
### DefineFolders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-VueRoutesModule'></a>
## VueRoutesModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes

##### Summary

Vue routes module for generation of all pages routes for router configuration in Vue application.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-VueRoutesModule-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [VueRoutesModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-VueRoutesModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.Routes.VueRoutesModule') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-VueRoutesModule-DefineFiles'></a>
### DefineFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-Routes-VueRoutesModule-DefineFolders'></a>
### DefineFolders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Abstractions-VueScaffoldModule'></a>
## VueScaffoldModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions

##### Summary

Abstract Vue module for generation of files supporting Vue applications.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Abstractions-VueScaffoldModule-#ctor-System-String,System-Boolean-'></a>
### #ctor(name,locked) `constructor`

##### Summary

Initializes a new instance of the [VueScaffoldModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Abstractions-VueScaffoldModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Abstractions.VueScaffoldModule') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| locked | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-VueStaticContentModule'></a>
## VueStaticContentModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent

##### Summary

Vue static content module for generation of components that represent the static content entities from the localization context in Vue application.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-VueStaticContentModule-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [VueStaticContentModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-VueStaticContentModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.StaticContent.VueStaticContentModule') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-VueStaticContentModule-DefineFiles'></a>
### DefineFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-StaticContent-VueStaticContentModule-DefineFolders'></a>
### DefineFolders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-VueTranslationsResourcesModule'></a>
## VueTranslationsResourcesModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources

##### Summary

Vue translation resources module for generation of all files (JSON) that contains the translations + their load i18n script in Vue application.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-VueTranslationsResourcesModule-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [VueTranslationsResourcesModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-VueTranslationsResourcesModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.TranslationsResources.VueTranslationsResourcesModule') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-VueTranslationsResourcesModule-DefineFiles'></a>
### DefineFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-TranslationsResources-VueTranslationsResourcesModule-DefineFolders'></a>
### DefineFolders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-VueWebApiModule'></a>
## VueWebApiModule `type`

##### Namespace

Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi

##### Summary

Vue web API module for generation of API endpoints as help functions and all supported classes and enums in Vue application.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-VueWebApiModule-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [VueWebApiModule](#T-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-VueWebApiModule 'Definux.Emeraude.Admin.ClientBuilder.Modules.Vue.Implementations.WebApi.VueWebApiModule') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-VueWebApiModule-DefineFiles'></a>
### DefineFiles() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Admin-ClientBuilder-Modules-Vue-Implementations-WebApi-VueWebApiModule-DefineFolders'></a>
### DefineFolders() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.
