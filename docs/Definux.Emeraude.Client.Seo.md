<a name='assembly'></a>
# Definux.Emeraude.Client.Seo

## Contents

- [CanonicalAttribute](#T-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute 'Definux.Emeraude.Client.Seo.Attributes.CanonicalAttribute')
  - [#ctor(href)](#M-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-#ctor-System-String- 'Definux.Emeraude.Client.Seo.Attributes.CanonicalAttribute.#ctor(System.String)')
  - [Href](#P-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-Href 'Definux.Emeraude.Client.Seo.Attributes.CanonicalAttribute.Href')
  - [ViewData](#P-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-ViewData 'Definux.Emeraude.Client.Seo.Attributes.CanonicalAttribute.ViewData')
  - [OnActionExecuted()](#M-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-OnActionExecuted-Microsoft-AspNetCore-Mvc-Filters-ActionExecutedContext- 'Definux.Emeraude.Client.Seo.Attributes.CanonicalAttribute.OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext)')
  - [OnActionExecuting()](#M-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext- 'Definux.Emeraude.Client.Seo.Attributes.CanonicalAttribute.OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)')
- [EmeraudeSeoController](#T-Definux-Emeraude-Client-Seo-EmeraudeSeoController 'Definux.Emeraude.Client.Seo.EmeraudeSeoController')
  - [Robots(robotsTxtReader)](#M-Definux-Emeraude-Client-Seo-EmeraudeSeoController-Robots-Definux-Emeraude-Client-Seo-IRobotsTxtReader- 'Definux.Emeraude.Client.Seo.EmeraudeSeoController.Robots(Definux.Emeraude.Client.Seo.IRobotsTxtReader)')
  - [Sitemap(sitemapBuilder)](#M-Definux-Emeraude-Client-Seo-EmeraudeSeoController-Sitemap-Definux-Emeraude-Client-Seo-ISitemapBuilder- 'Definux.Emeraude.Client.Seo.EmeraudeSeoController.Sitemap(Definux.Emeraude.Client.Seo.ISitemapBuilder)')
- [IRobotsTxtReader](#T-Definux-Emeraude-Client-Seo-IRobotsTxtReader 'Definux.Emeraude.Client.Seo.IRobotsTxtReader')
  - [GetRobotsTxt()](#M-Definux-Emeraude-Client-Seo-IRobotsTxtReader-GetRobotsTxt 'Definux.Emeraude.Client.Seo.IRobotsTxtReader.GetRobotsTxt')
- [ISitemapBuilder](#T-Definux-Emeraude-Client-Seo-ISitemapBuilder 'Definux.Emeraude.Client.Seo.ISitemapBuilder')
  - [BuildSitemapAsync()](#M-Definux-Emeraude-Client-Seo-ISitemapBuilder-BuildSitemapAsync 'Definux.Emeraude.Client.Seo.ISitemapBuilder.BuildSitemapAsync')
- [ISitemapComposition](#T-Definux-Emeraude-Client-Seo-ISitemapComposition 'Definux.Emeraude.Client.Seo.ISitemapComposition')
  - [SetupAsync()](#M-Definux-Emeraude-Client-Seo-ISitemapComposition-SetupAsync 'Definux.Emeraude.Client.Seo.ISitemapComposition.SetupAsync')
- [MainMetaTags](#T-Definux-Emeraude-Client-Seo-Models-MainMetaTags 'Definux.Emeraude.Client.Seo.Models.MainMetaTags')
  - [Author](#F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Author 'Definux.Emeraude.Client.Seo.Models.MainMetaTags.Author')
  - [Description](#F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Description 'Definux.Emeraude.Client.Seo.Models.MainMetaTags.Description')
  - [Image](#F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Image 'Definux.Emeraude.Client.Seo.Models.MainMetaTags.Image')
  - [Keywords](#F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Keywords 'Definux.Emeraude.Client.Seo.Models.MainMetaTags.Keywords')
  - [Title](#F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Title 'Definux.Emeraude.Client.Seo.Models.MainMetaTags.Title')
- [MetaTag](#T-Definux-Emeraude-Client-Seo-Models-MetaTag 'Definux.Emeraude.Client.Seo.Models.MetaTag')
  - [#ctor()](#M-Definux-Emeraude-Client-Seo-Models-MetaTag-#ctor 'Definux.Emeraude.Client.Seo.Models.MetaTag.#ctor')
  - [#ctor(key)](#M-Definux-Emeraude-Client-Seo-Models-MetaTag-#ctor-System-String- 'Definux.Emeraude.Client.Seo.Models.MetaTag.#ctor(System.String)')
  - [#ctor(name,value)](#M-Definux-Emeraude-Client-Seo-Models-MetaTag-#ctor-System-String,System-String- 'Definux.Emeraude.Client.Seo.Models.MetaTag.#ctor(System.String,System.String)')
  - [HasValue](#P-Definux-Emeraude-Client-Seo-Models-MetaTag-HasValue 'Definux.Emeraude.Client.Seo.Models.MetaTag.HasValue')
  - [Key](#P-Definux-Emeraude-Client-Seo-Models-MetaTag-Key 'Definux.Emeraude.Client.Seo.Models.MetaTag.Key')
  - [KeyName](#P-Definux-Emeraude-Client-Seo-Models-MetaTag-KeyName 'Definux.Emeraude.Client.Seo.Models.MetaTag.KeyName')
  - [Value](#P-Definux-Emeraude-Client-Seo-Models-MetaTag-Value 'Definux.Emeraude.Client.Seo.Models.MetaTag.Value')
  - [ValueName](#P-Definux-Emeraude-Client-Seo-Models-MetaTag-ValueName 'Definux.Emeraude.Client.Seo.Models.MetaTag.ValueName')
  - [ToString()](#M-Definux-Emeraude-Client-Seo-Models-MetaTag-ToString 'Definux.Emeraude.Client.Seo.Models.MetaTag.ToString')
- [MetaTagAttribute](#T-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute')
  - [#ctor(type,value,extractValueFromViewData)](#M-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-#ctor-Definux-Emeraude-Client-Seo-Models-MainMetaTags,System-String,System-Boolean- 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute.#ctor(Definux.Emeraude.Client.Seo.Models.MainMetaTags,System.String,System.Boolean)')
  - [ExtractValueFromViewData](#P-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-ExtractValueFromViewData 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute.ExtractValueFromViewData')
  - [Type](#P-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-Type 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute.Type')
  - [Value](#P-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-Value 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute.Value')
  - [ViewData](#P-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-ViewData 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute.ViewData')
  - [OnActionExecuted()](#M-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-OnActionExecuted-Microsoft-AspNetCore-Mvc-Filters-ActionExecutedContext- 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute.OnActionExecuted(Microsoft.AspNetCore.Mvc.Filters.ActionExecutedContext)')
  - [OnActionExecuting()](#M-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext- 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute.OnActionExecuting(Microsoft.AspNetCore.Mvc.Filters.ActionExecutingContext)')
- [MetaTagsModel](#T-Definux-Emeraude-Client-Seo-Models-MetaTagsModel 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel')
  - [Author](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Author 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.Author')
  - [Canonical](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Canonical 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.Canonical')
  - [Charset](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Charset 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.Charset')
  - [Description](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Description 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.Description')
  - [FacebookAppId](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-FacebookAppId 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.FacebookAppId')
  - [Keywords](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Keywords 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.Keywords')
  - [OpenGraphDescription](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphDescription 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.OpenGraphDescription')
  - [OpenGraphImage](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphImage 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.OpenGraphImage')
  - [OpenGraphSiteName](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphSiteName 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.OpenGraphSiteName')
  - [OpenGraphTitle](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphTitle 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.OpenGraphTitle')
  - [OpenGraphType](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphType 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.OpenGraphType')
  - [OpenGraphUrl](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphUrl 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.OpenGraphUrl')
  - [Robots](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Robots 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.Robots')
  - [Title](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Title 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.Title')
  - [TitleSuffix](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TitleSuffix 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.TitleSuffix')
  - [TwitterCard](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterCard 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.TwitterCard')
  - [TwitterCreator](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterCreator 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.TwitterCreator')
  - [TwitterDescription](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterDescription 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.TwitterDescription')
  - [TwitterImage](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterImage 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.TwitterImage')
  - [TwitterSite](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterSite 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.TwitterSite')
  - [TwitterTitle](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterTitle 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.TwitterTitle')
  - [Viewport](#P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Viewport 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.Viewport')
  - [ApplyStaticTags(model)](#M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-ApplyStaticTags-Definux-Emeraude-Client-Seo-Models-MetaTagsModel- 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.ApplyStaticTags(Definux.Emeraude.Client.Seo.Models.MetaTagsModel)')
  - [GetFilledMetaTags()](#M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-GetFilledMetaTags 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.GetFilledMetaTags')
  - [GetStartMetaTags()](#M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-GetStartMetaTags 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.GetStartMetaTags')
  - [SetDescription(description)](#M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-SetDescription-System-String- 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.SetDescription(System.String)')
  - [SetImage(imageUrl)](#M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-SetImage-System-String- 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.SetImage(System.String)')
  - [SetMetaTag(metaTag,value)](#M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-SetMetaTag-Definux-Emeraude-Client-Seo-Models-MainMetaTags,System-String- 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.SetMetaTag(Definux.Emeraude.Client.Seo.Models.MainMetaTags,System.String)')
  - [SetTitle(title)](#M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-SetTitle-System-String- 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel.SetTitle(System.String)')
- [PageSitemapPattern](#T-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern')
  - [#ctor(template,languageStore)](#M-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-#ctor-System-String,Definux-Emeraude-Application-Localization-ILanguageStore- 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern.#ctor(System.String,Definux.Emeraude.Application.Localization.ILanguageStore)')
  - [ChangeFrequency](#P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-ChangeFrequency 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern.ChangeFrequency')
  - [DataAccessor](#P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-DataAccessor 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern.DataAccessor')
  - [Domain](#P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-Domain 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern.Domain')
  - [Patterns](#P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-Patterns 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern.Patterns')
  - [Priority](#P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-Priority 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern.Priority')
  - [SinglePage](#P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-SinglePage 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern.SinglePage')
  - [BuildPatternUrlsAsync()](#M-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-BuildPatternUrlsAsync 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern.BuildPatternUrlsAsync')
  - [SetBaseUrl(baseUrl)](#M-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-SetBaseUrl-System-String- 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern.SetBaseUrl(System.String)')
- [RobotsTxtReader](#T-Definux-Emeraude-Client-Seo-RobotsTxtReader 'Definux.Emeraude.Client.Seo.RobotsTxtReader')
  - [#ctor(hostingEnvironment)](#M-Definux-Emeraude-Client-Seo-RobotsTxtReader-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment- 'Definux.Emeraude.Client.Seo.RobotsTxtReader.#ctor(Microsoft.AspNetCore.Hosting.IHostingEnvironment)')
  - [GetRobotsTxt()](#M-Definux-Emeraude-Client-Seo-RobotsTxtReader-GetRobotsTxt 'Definux.Emeraude.Client.Seo.RobotsTxtReader.GetRobotsTxt')
- [SeoChangeFrequencyTypes](#T-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes 'Definux.Emeraude.Client.Seo.Models.SeoChangeFrequencyTypes')
  - [Always](#F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Always 'Definux.Emeraude.Client.Seo.Models.SeoChangeFrequencyTypes.Always')
  - [Daily](#F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Daily 'Definux.Emeraude.Client.Seo.Models.SeoChangeFrequencyTypes.Daily')
  - [Hourly](#F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Hourly 'Definux.Emeraude.Client.Seo.Models.SeoChangeFrequencyTypes.Hourly')
  - [Monthly](#F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Monthly 'Definux.Emeraude.Client.Seo.Models.SeoChangeFrequencyTypes.Monthly')
  - [Never](#F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Never 'Definux.Emeraude.Client.Seo.Models.SeoChangeFrequencyTypes.Never')
  - [Weekly](#F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Weekly 'Definux.Emeraude.Client.Seo.Models.SeoChangeFrequencyTypes.Weekly')
  - [Yearly](#F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Yearly 'Definux.Emeraude.Client.Seo.Models.SeoChangeFrequencyTypes.Yearly')
- [SeoMetaTagsTagHelper](#T-Definux-Emeraude-Client-Seo-TagHelpers-SeoMetaTagsTagHelper 'Definux.Emeraude.Client.Seo.TagHelpers.SeoMetaTagsTagHelper')
  - [#ctor(optionsAccessor)](#M-Definux-Emeraude-Client-Seo-TagHelpers-SeoMetaTagsTagHelper-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Client-Seo-Options-SeoOptions}- 'Definux.Emeraude.Client.Seo.TagHelpers.SeoMetaTagsTagHelper.#ctor(Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Client.Seo.Options.SeoOptions})')
  - [ViewContext](#P-Definux-Emeraude-Client-Seo-TagHelpers-SeoMetaTagsTagHelper-ViewContext 'Definux.Emeraude.Client.Seo.TagHelpers.SeoMetaTagsTagHelper.ViewContext')
  - [Process()](#M-Definux-Emeraude-Client-Seo-TagHelpers-SeoMetaTagsTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput- 'Definux.Emeraude.Client.Seo.TagHelpers.SeoMetaTagsTagHelper.Process(Microsoft.AspNetCore.Razor.TagHelpers.TagHelperContext,Microsoft.AspNetCore.Razor.TagHelpers.TagHelperOutput)')
- [SeoOptions](#T-Definux-Emeraude-Client-Seo-Options-SeoOptions 'Definux.Emeraude.Client.Seo.Options.SeoOptions')
  - [#ctor()](#M-Definux-Emeraude-Client-Seo-Options-SeoOptions-#ctor 'Definux.Emeraude.Client.Seo.Options.SeoOptions.#ctor')
  - [DefaultMetaTags](#P-Definux-Emeraude-Client-Seo-Options-SeoOptions-DefaultMetaTags 'Definux.Emeraude.Client.Seo.Options.SeoOptions.DefaultMetaTags')
  - [SitemapCompositionType](#P-Definux-Emeraude-Client-Seo-Options-SeoOptions-SitemapCompositionType 'Definux.Emeraude.Client.Seo.Options.SeoOptions.SitemapCompositionType')
  - [SetSitemapComposition\`\`1()](#M-Definux-Emeraude-Client-Seo-Options-SeoOptions-SetSitemapComposition``1 'Definux.Emeraude.Client.Seo.Options.SeoOptions.SetSitemapComposition``1')
- [ServiceCollectionExtensions](#T-Definux-Emeraude-Client-Seo-Extensions-ServiceCollectionExtensions 'Definux.Emeraude.Client.Seo.Extensions.ServiceCollectionExtensions')
  - [AddSeo(services,optionsAction)](#M-Definux-Emeraude-Client-Seo-Extensions-ServiceCollectionExtensions-AddSeo-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Definux-Emeraude-Client-Seo-Options-SeoOptions}- 'Definux.Emeraude.Client.Seo.Extensions.ServiceCollectionExtensions.AddSeo(Microsoft.Extensions.DependencyInjection.IServiceCollection,System.Action{Definux.Emeraude.Client.Seo.Options.SeoOptions})')
- [SitemapBuilder](#T-Definux-Emeraude-Client-Seo-SitemapBuilder 'Definux.Emeraude.Client.Seo.SitemapBuilder')
  - [#ctor(sitemapComposition,httpContextAccessor)](#M-Definux-Emeraude-Client-Seo-SitemapBuilder-#ctor-Definux-Emeraude-Client-Seo-ISitemapComposition,Microsoft-AspNetCore-Http-IHttpContextAccessor- 'Definux.Emeraude.Client.Seo.SitemapBuilder.#ctor(Definux.Emeraude.Client.Seo.ISitemapComposition,Microsoft.AspNetCore.Http.IHttpContextAccessor)')
  - [BuildSitemapAsync()](#M-Definux-Emeraude-Client-Seo-SitemapBuilder-BuildSitemapAsync 'Definux.Emeraude.Client.Seo.SitemapBuilder.BuildSitemapAsync')
- [SitemapResult](#T-Definux-Emeraude-Client-Seo-Results-SitemapResult 'Definux.Emeraude.Client.Seo.Results.SitemapResult')
  - [#ctor()](#M-Definux-Emeraude-Client-Seo-Results-SitemapResult-#ctor 'Definux.Emeraude.Client.Seo.Results.SitemapResult.#ctor')
  - [Urls](#P-Definux-Emeraude-Client-Seo-Results-SitemapResult-Urls 'Definux.Emeraude.Client.Seo.Results.SitemapResult.Urls')
  - [ToSerializedSitemapXml()](#M-Definux-Emeraude-Client-Seo-Results-SitemapResult-ToSerializedSitemapXml 'Definux.Emeraude.Client.Seo.Results.SitemapResult.ToSerializedSitemapXml')
- [SitemapUrl](#T-Definux-Emeraude-Client-Seo-Results-SitemapUrl 'Definux.Emeraude.Client.Seo.Results.SitemapUrl')
  - [ChangeFrequency](#P-Definux-Emeraude-Client-Seo-Results-SitemapUrl-ChangeFrequency 'Definux.Emeraude.Client.Seo.Results.SitemapUrl.ChangeFrequency')
  - [LastModification](#P-Definux-Emeraude-Client-Seo-Results-SitemapUrl-LastModification 'Definux.Emeraude.Client.Seo.Results.SitemapUrl.LastModification')
  - [Location](#P-Definux-Emeraude-Client-Seo-Results-SitemapUrl-Location 'Definux.Emeraude.Client.Seo.Results.SitemapUrl.Location')
  - [Priority](#P-Definux-Emeraude-Client-Seo-Results-SitemapUrl-Priority 'Definux.Emeraude.Client.Seo.Results.SitemapUrl.Priority')
- [ViewDataDictionaryExtensions](#T-Definux-Emeraude-Client-Seo-Extensions-ViewDataDictionaryExtensions 'Definux.Emeraude.Client.Seo.Extensions.ViewDataDictionaryExtensions')
  - [ApplyMetaTagsModel(viewData,model)](#M-Definux-Emeraude-Client-Seo-Extensions-ViewDataDictionaryExtensions-ApplyMetaTagsModel-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,Definux-Emeraude-Client-Seo-Models-MetaTagsModel- 'Definux.Emeraude.Client.Seo.Extensions.ViewDataDictionaryExtensions.ApplyMetaTagsModel(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary,Definux.Emeraude.Client.Seo.Models.MetaTagsModel)')
  - [GetMetaTagsModelOrDefault(viewData)](#M-Definux-Emeraude-Client-Seo-Extensions-ViewDataDictionaryExtensions-GetMetaTagsModelOrDefault-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Client.Seo.Extensions.ViewDataDictionaryExtensions.GetMetaTagsModelOrDefault(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')
  - [GetOrCreateCurrentMetaTagsModel(viewData)](#M-Definux-Emeraude-Client-Seo-Extensions-ViewDataDictionaryExtensions-GetOrCreateCurrentMetaTagsModel-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary- 'Definux.Emeraude.Client.Seo.Extensions.ViewDataDictionaryExtensions.GetOrCreateCurrentMetaTagsModel(Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary)')

<a name='T-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute'></a>
## CanonicalAttribute `type`

##### Namespace

Definux.Emeraude.Client.Seo.Attributes

##### Summary

Canonical attribute that set a href of current page into canonical link tag into the ViewData.

<a name='M-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-#ctor-System-String-'></a>
### #ctor(href) `constructor`

##### Summary

Initializes a new instance of the [CanonicalAttribute](#T-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute 'Definux.Emeraude.Client.Seo.Attributes.CanonicalAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| href | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-Href'></a>
### Href `property`

##### Summary

Href value of the link tag.

<a name='P-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-ViewData'></a>
### ViewData `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-OnActionExecuted-Microsoft-AspNetCore-Mvc-Filters-ActionExecutedContext-'></a>
### OnActionExecuted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Seo-Attributes-CanonicalAttribute-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext-'></a>
### OnActionExecuting() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-EmeraudeSeoController'></a>
## EmeraudeSeoController `type`

##### Namespace

Definux.Emeraude.Client.Seo

##### Summary

Main controller of SEO endpoints.

<a name='M-Definux-Emeraude-Client-Seo-EmeraudeSeoController-Robots-Definux-Emeraude-Client-Seo-IRobotsTxtReader-'></a>
### Robots(robotsTxtReader) `method`

##### Summary

Action of the robots.txt file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| robotsTxtReader | [Definux.Emeraude.Client.Seo.IRobotsTxtReader](#T-Definux-Emeraude-Client-Seo-IRobotsTxtReader 'Definux.Emeraude.Client.Seo.IRobotsTxtReader') |  |

<a name='M-Definux-Emeraude-Client-Seo-EmeraudeSeoController-Sitemap-Definux-Emeraude-Client-Seo-ISitemapBuilder-'></a>
### Sitemap(sitemapBuilder) `method`

##### Summary

Action of the sitemap.xml file.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sitemapBuilder | [Definux.Emeraude.Client.Seo.ISitemapBuilder](#T-Definux-Emeraude-Client-Seo-ISitemapBuilder 'Definux.Emeraude.Client.Seo.ISitemapBuilder') |  |

<a name='T-Definux-Emeraude-Client-Seo-IRobotsTxtReader'></a>
## IRobotsTxtReader `type`

##### Namespace

Definux.Emeraude.Client.Seo

##### Summary

Service that read the robots.txt file from the main directory of the application.

<a name='M-Definux-Emeraude-Client-Seo-IRobotsTxtReader-GetRobotsTxt'></a>
### GetRobotsTxt() `method`

##### Summary

Gets the robots.txt file and converts it into string.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-ISitemapBuilder'></a>
## ISitemapBuilder `type`

##### Namespace

Definux.Emeraude.Client.Seo

##### Summary

Service that process and build sitemap of the application.

<a name='M-Definux-Emeraude-Client-Seo-ISitemapBuilder-BuildSitemapAsync'></a>
### BuildSitemapAsync() `method`

##### Summary

Builds sitemap based on applied sitemap patterns.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-ISitemapComposition'></a>
## ISitemapComposition `type`

##### Namespace

Definux.Emeraude.Client.Seo

##### Summary

Main interface for setup all [PageSitemapPattern](#T-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern').

<a name='M-Definux-Emeraude-Client-Seo-ISitemapComposition-SetupAsync'></a>
### SetupAsync() `method`

##### Summary

Setup method for defining all sitemap patterns.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-Models-MainMetaTags'></a>
## MainMetaTags `type`

##### Namespace

Definux.Emeraude.Client.Seo.Models

##### Summary

The most used meta tags.

<a name='F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Author'></a>
### Author `constants`

##### Summary

Author meta tag.

<a name='F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Description'></a>
### Description `constants`

##### Summary

Description meta tag.

<a name='F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Image'></a>
### Image `constants`

##### Summary

Image mata tag.

<a name='F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Keywords'></a>
### Keywords `constants`

##### Summary

Keywords meta tag.

<a name='F-Definux-Emeraude-Client-Seo-Models-MainMetaTags-Title'></a>
### Title `constants`

##### Summary

Title.

<a name='T-Definux-Emeraude-Client-Seo-Models-MetaTag'></a>
## MetaTag `type`

##### Namespace

Definux.Emeraude.Client.Seo.Models

##### Summary

Implementation of single HTML meta tag.

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTag-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [MetaTag](#T-Definux-Emeraude-Client-Seo-Models-MetaTag 'Definux.Emeraude.Client.Seo.Models.MetaTag') class.

##### Parameters

This constructor has no parameters.

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTag-#ctor-System-String-'></a>
### #ctor(key) `constructor`

##### Summary

Initializes a new instance of the [MetaTag](#T-Definux-Emeraude-Client-Seo-Models-MetaTag 'Definux.Emeraude.Client.Seo.Models.MetaTag') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| key | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTag-#ctor-System-String,System-String-'></a>
### #ctor(name,value) `constructor`

##### Summary

Initializes a new instance of the [MetaTag](#T-Definux-Emeraude-Client-Seo-Models-MetaTag 'Definux.Emeraude.Client.Seo.Models.MetaTag') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTag-HasValue'></a>
### HasValue `property`

##### Summary

Flag that returns whether the meta tag has value.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTag-Key'></a>
### Key `property`

##### Summary

Key of the meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTag-KeyName'></a>
### KeyName `property`

##### Summary

Key attribute name of the meta tag. Default value is 'name'.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTag-Value'></a>
### Value `property`

##### Summary

Value of the meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTag-ValueName'></a>
### ValueName `property`

##### Summary

Value attribute name of the meta tag. Default value is 'content'.

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTag-ToString'></a>
### ToString() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute'></a>
## MetaTagAttribute `type`

##### Namespace

Definux.Emeraude.Client.Seo.Attributes

##### Summary

Meta tag attribute that set a main meta tag item into the ViewData.

<a name='M-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-#ctor-Definux-Emeraude-Client-Seo-Models-MainMetaTags,System-String,System-Boolean-'></a>
### #ctor(type,value,extractValueFromViewData) `constructor`

##### Summary

Initializes a new instance of the [MetaTagAttribute](#T-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| type | [Definux.Emeraude.Client.Seo.Models.MainMetaTags](#T-Definux-Emeraude-Client-Seo-Models-MainMetaTags 'Definux.Emeraude.Client.Seo.Models.MainMetaTags') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| extractValueFromViewData | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') |  |

<a name='P-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-ExtractValueFromViewData'></a>
### ExtractValueFromViewData `property`

##### Summary

Flag that indicates whether the meta tag value be extracted from the ViewData or not.

<a name='P-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-Type'></a>
### Type `property`

##### Summary

Type of the meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-Value'></a>
### Value `property`

##### Summary

Value of the meta tag. In case when [ExtractValueFromViewData](#P-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-ExtractValueFromViewData 'Definux.Emeraude.Client.Seo.Attributes.MetaTagAttribute.ExtractValueFromViewData') is set to true, the meta tag value will be used as a ViewData key.

<a name='P-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-ViewData'></a>
### ViewData `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-OnActionExecuted-Microsoft-AspNetCore-Mvc-Filters-ActionExecutedContext-'></a>
### OnActionExecuted() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Seo-Attributes-MetaTagAttribute-OnActionExecuting-Microsoft-AspNetCore-Mvc-Filters-ActionExecutingContext-'></a>
### OnActionExecuting() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-Models-MetaTagsModel'></a>
## MetaTagsModel `type`

##### Namespace

Definux.Emeraude.Client.Seo.Models

##### Summary

Implementation of meta tags for HTML for search engine optimization.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Author'></a>
### Author `property`

##### Summary

Author of the page.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Canonical'></a>
### Canonical `property`

##### Summary

Canonical link of the page.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Charset'></a>
### Charset `property`

##### Summary

HTML charset. Default value is "utf-8".

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Description'></a>
### Description `property`

##### Summary

Description of the page.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-FacebookAppId'></a>
### FacebookAppId `property`

##### Summary

Facebook application id meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Keywords'></a>
### Keywords `property`

##### Summary

Keywords of the page.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphDescription'></a>
### OpenGraphDescription `property`

##### Summary

Facebook Open Graph description meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphImage'></a>
### OpenGraphImage `property`

##### Summary

Facebook Open Graph image meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphSiteName'></a>
### OpenGraphSiteName `property`

##### Summary

Facebook Open Graph site name meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphTitle'></a>
### OpenGraphTitle `property`

##### Summary

Facebook Open Graph title meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphType'></a>
### OpenGraphType `property`

##### Summary

Facebook Open Graph type meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-OpenGraphUrl'></a>
### OpenGraphUrl `property`

##### Summary

Facebook Open Graph URL meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Robots'></a>
### Robots `property`

##### Summary

Robots tag. Default value is "index, follow".

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Title'></a>
### Title `property`

##### Summary

Title of the page.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TitleSuffix'></a>
### TitleSuffix `property`

##### Summary

Title suffix for all pages. Example ' | Application' for 'Home | Application'.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterCard'></a>
### TwitterCard `property`

##### Summary

Twitter card meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterCreator'></a>
### TwitterCreator `property`

##### Summary

Twitter creator meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterDescription'></a>
### TwitterDescription `property`

##### Summary

Twitter description meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterImage'></a>
### TwitterImage `property`

##### Summary

Twitter image meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterSite'></a>
### TwitterSite `property`

##### Summary

Twitter site meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-TwitterTitle'></a>
### TwitterTitle `property`

##### Summary

Twitter title meta tag.

<a name='P-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-Viewport'></a>
### Viewport `property`

##### Summary

Viewport of the HTML. Default value is "width=device-width, initial-scale=1.0".

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-ApplyStaticTags-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-'></a>
### ApplyStaticTags(model) `method`

##### Summary

Apply static meta tags to the current meta tag model.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| model | [Definux.Emeraude.Client.Seo.Models.MetaTagsModel](#T-Definux-Emeraude-Client-Seo-Models-MetaTagsModel 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel') |  |

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-GetFilledMetaTags'></a>
### GetFilledMetaTags() `method`

##### Summary

Gets list of all filled meta tags.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-GetStartMetaTags'></a>
### GetStartMetaTags() `method`

##### Summary

Gets a list of all default meta tags.

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-SetDescription-System-String-'></a>
### SetDescription(description) `method`

##### Summary

Set description of the page.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| description | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-SetImage-System-String-'></a>
### SetImage(imageUrl) `method`

##### Summary

Set image of the page.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| imageUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-SetMetaTag-Definux-Emeraude-Client-Seo-Models-MainMetaTags,System-String-'></a>
### SetMetaTag(metaTag,value) `method`

##### Summary

Set meta tag and its value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| metaTag | [Definux.Emeraude.Client.Seo.Models.MainMetaTags](#T-Definux-Emeraude-Client-Seo-Models-MainMetaTags 'Definux.Emeraude.Client.Seo.Models.MainMetaTags') |  |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='M-Definux-Emeraude-Client-Seo-Models-MetaTagsModel-SetTitle-System-String-'></a>
### SetTitle(title) `method`

##### Summary

Set title of the page.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| title | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern'></a>
## PageSitemapPattern `type`

##### Namespace

Definux.Emeraude.Client.Seo.Models

##### Summary

Definition of sitemap page structure. Its purpose is to defines the pattern of single/multiple page/s of the sitemap.

<a name='M-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-#ctor-System-String,Definux-Emeraude-Application-Localization-ILanguageStore-'></a>
### #ctor(template,languageStore) `constructor`

##### Summary

Initializes a new instance of the [PageSitemapPattern](#T-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern 'Definux.Emeraude.Client.Seo.Models.PageSitemapPattern') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| template | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |
| languageStore | [Definux.Emeraude.Application.Localization.ILanguageStore](#T-Definux-Emeraude-Application-Localization-ILanguageStore 'Definux.Emeraude.Application.Localization.ILanguageStore') |  |

<a name='P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-ChangeFrequency'></a>
### ChangeFrequency `property`

##### Summary

*Inherit from parent.*

<a name='P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-DataAccessor'></a>
### DataAccessor `property`

##### Summary

Function that contains logic for accessing data from any source for generating the sitemap.

<a name='P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-Domain'></a>
### Domain `property`

##### Summary

Domain name of the current sitemap page. This property is with priority than base URL.

<a name='P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-Patterns'></a>
### Patterns `property`

##### Summary

Collection of all page patterns which will be applied for the current object URL generation.

<a name='P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-Priority'></a>
### Priority `property`

##### Summary

Priority of the sitemap page for search engines.

<a name='P-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-SinglePage'></a>
### SinglePage `property`

##### Summary

Flag indicates that the pattern will be applied into a single page or not.

<a name='M-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-BuildPatternUrlsAsync'></a>
### BuildPatternUrlsAsync() `method`

##### Summary

Builds the collection of sitemap URLs that must be added to the [SitemapResult](#T-Definux-Emeraude-Client-Seo-Results-SitemapResult 'Definux.Emeraude.Client.Seo.Results.SitemapResult').

##### Returns



##### Parameters

This method has no parameters.

<a name='M-Definux-Emeraude-Client-Seo-Models-PageSitemapPattern-SetBaseUrl-System-String-'></a>
### SetBaseUrl(baseUrl) `method`

##### Summary

Set the base URL of the page.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| baseUrl | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') |  |

<a name='T-Definux-Emeraude-Client-Seo-RobotsTxtReader'></a>
## RobotsTxtReader `type`

##### Namespace

Definux.Emeraude.Client.Seo

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-Seo-RobotsTxtReader-#ctor-Microsoft-AspNetCore-Hosting-IHostingEnvironment-'></a>
### #ctor(hostingEnvironment) `constructor`

##### Summary

Initializes a new instance of the [RobotsTxtReader](#T-Definux-Emeraude-Client-Seo-RobotsTxtReader 'Definux.Emeraude.Client.Seo.RobotsTxtReader') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| hostingEnvironment | [Microsoft.AspNetCore.Hosting.IHostingEnvironment](#T-Microsoft-AspNetCore-Hosting-IHostingEnvironment 'Microsoft.AspNetCore.Hosting.IHostingEnvironment') |  |

<a name='M-Definux-Emeraude-Client-Seo-RobotsTxtReader-GetRobotsTxt'></a>
### GetRobotsTxt() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes'></a>
## SeoChangeFrequencyTypes `type`

##### Namespace

Definux.Emeraude.Client.Seo.Models

##### Summary

Sitemap pages change frequency.

<a name='F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Always'></a>
### Always `constants`

##### Summary

Type 'Always'.

<a name='F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Daily'></a>
### Daily `constants`

##### Summary

Type 'Daily'.

<a name='F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Hourly'></a>
### Hourly `constants`

##### Summary

Type 'Hourly'.

<a name='F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Monthly'></a>
### Monthly `constants`

##### Summary

Type 'Monthly'.

<a name='F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Never'></a>
### Never `constants`

##### Summary

Type 'Never'.

<a name='F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Weekly'></a>
### Weekly `constants`

##### Summary

Type 'Weekly'.

<a name='F-Definux-Emeraude-Client-Seo-Models-SeoChangeFrequencyTypes-Yearly'></a>
### Yearly `constants`

##### Summary

Type 'Yearly'.

<a name='T-Definux-Emeraude-Client-Seo-TagHelpers-SeoMetaTagsTagHelper'></a>
## SeoMetaTagsTagHelper `type`

##### Namespace

Definux.Emeraude.Client.Seo.TagHelpers

##### Summary

Tag helper that create all SEO tags based on the decoration of controller or action.

<a name='M-Definux-Emeraude-Client-Seo-TagHelpers-SeoMetaTagsTagHelper-#ctor-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Client-Seo-Options-SeoOptions}-'></a>
### #ctor(optionsAccessor) `constructor`

##### Summary

Initializes a new instance of the [SeoMetaTagsTagHelper](#T-Definux-Emeraude-Client-Seo-TagHelpers-SeoMetaTagsTagHelper 'Definux.Emeraude.Client.Seo.TagHelpers.SeoMetaTagsTagHelper') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| optionsAccessor | [Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Client.Seo.Options.SeoOptions}](#T-Microsoft-Extensions-Options-IOptions{Definux-Emeraude-Client-Seo-Options-SeoOptions} 'Microsoft.Extensions.Options.IOptions{Definux.Emeraude.Client.Seo.Options.SeoOptions}') |  |

<a name='P-Definux-Emeraude-Client-Seo-TagHelpers-SeoMetaTagsTagHelper-ViewContext'></a>
### ViewContext `property`

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-Seo-TagHelpers-SeoMetaTagsTagHelper-Process-Microsoft-AspNetCore-Razor-TagHelpers-TagHelperContext,Microsoft-AspNetCore-Razor-TagHelpers-TagHelperOutput-'></a>
### Process() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-Options-SeoOptions'></a>
## SeoOptions `type`

##### Namespace

Definux.Emeraude.Client.Seo.Options

##### Summary

Implementation of SEO plugin options.

<a name='M-Definux-Emeraude-Client-Seo-Options-SeoOptions-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [SeoOptions](#T-Definux-Emeraude-Client-Seo-Options-SeoOptions 'Definux.Emeraude.Client.Seo.Options.SeoOptions') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Client-Seo-Options-SeoOptions-DefaultMetaTags'></a>
### DefaultMetaTags `property`

##### Summary

Default meta tags model.

<a name='P-Definux-Emeraude-Client-Seo-Options-SeoOptions-SitemapCompositionType'></a>
### SitemapCompositionType `property`

##### Summary

Implementation type of [ISitemapComposition](#T-Definux-Emeraude-Client-Seo-ISitemapComposition 'Definux.Emeraude.Client.Seo.ISitemapComposition').

<a name='M-Definux-Emeraude-Client-Seo-Options-SeoOptions-SetSitemapComposition``1'></a>
### SetSitemapComposition\`\`1() `method`

##### Summary

Set sitemap composition type.

##### Parameters

This method has no parameters.

##### Generic Types

| Name | Description |
| ---- | ----------- |
| TSitemapComposition | Sitemap composition implementation type. |

<a name='T-Definux-Emeraude-Client-Seo-Extensions-ServiceCollectionExtensions'></a>
## ServiceCollectionExtensions `type`

##### Namespace

Definux.Emeraude.Client.Seo.Extensions

##### Summary

Extensions for [IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection').

<a name='M-Definux-Emeraude-Client-Seo-Extensions-ServiceCollectionExtensions-AddSeo-Microsoft-Extensions-DependencyInjection-IServiceCollection,System-Action{Definux-Emeraude-Client-Seo-Options-SeoOptions}-'></a>
### AddSeo(services,optionsAction) `method`

##### Summary

Register SEO services.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| services | [Microsoft.Extensions.DependencyInjection.IServiceCollection](#T-Microsoft-Extensions-DependencyInjection-IServiceCollection 'Microsoft.Extensions.DependencyInjection.IServiceCollection') |  |
| optionsAction | [System.Action{Definux.Emeraude.Client.Seo.Options.SeoOptions}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Action 'System.Action{Definux.Emeraude.Client.Seo.Options.SeoOptions}') |  |

<a name='T-Definux-Emeraude-Client-Seo-SitemapBuilder'></a>
## SitemapBuilder `type`

##### Namespace

Definux.Emeraude.Client.Seo

##### Summary

*Inherit from parent.*

<a name='M-Definux-Emeraude-Client-Seo-SitemapBuilder-#ctor-Definux-Emeraude-Client-Seo-ISitemapComposition,Microsoft-AspNetCore-Http-IHttpContextAccessor-'></a>
### #ctor(sitemapComposition,httpContextAccessor) `constructor`

##### Summary

Initializes a new instance of the [SitemapBuilder](#T-Definux-Emeraude-Client-Seo-SitemapBuilder 'Definux.Emeraude.Client.Seo.SitemapBuilder') class.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| sitemapComposition | [Definux.Emeraude.Client.Seo.ISitemapComposition](#T-Definux-Emeraude-Client-Seo-ISitemapComposition 'Definux.Emeraude.Client.Seo.ISitemapComposition') |  |
| httpContextAccessor | [Microsoft.AspNetCore.Http.IHttpContextAccessor](#T-Microsoft-AspNetCore-Http-IHttpContextAccessor 'Microsoft.AspNetCore.Http.IHttpContextAccessor') |  |

<a name='M-Definux-Emeraude-Client-Seo-SitemapBuilder-BuildSitemapAsync'></a>
### BuildSitemapAsync() `method`

##### Summary

*Inherit from parent.*

##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-Results-SitemapResult'></a>
## SitemapResult `type`

##### Namespace

Definux.Emeraude.Client.Seo.Results

##### Summary

Implementation of application sitemap.

<a name='M-Definux-Emeraude-Client-Seo-Results-SitemapResult-#ctor'></a>
### #ctor() `constructor`

##### Summary

Initializes a new instance of the [SitemapResult](#T-Definux-Emeraude-Client-Seo-Results-SitemapResult 'Definux.Emeraude.Client.Seo.Results.SitemapResult') class.

##### Parameters

This constructor has no parameters.

<a name='P-Definux-Emeraude-Client-Seo-Results-SitemapResult-Urls'></a>
### Urls `property`

##### Summary

Collection of sitemap pages URLs.

<a name='M-Definux-Emeraude-Client-Seo-Results-SitemapResult-ToSerializedSitemapXml'></a>
### ToSerializedSitemapXml() `method`

##### Summary

Converts sitemap result to a sitemap XML format.

##### Returns



##### Parameters

This method has no parameters.

<a name='T-Definux-Emeraude-Client-Seo-Results-SitemapUrl'></a>
## SitemapUrl `type`

##### Namespace

Definux.Emeraude.Client.Seo.Results

##### Summary

Sitemap page URL.

<a name='P-Definux-Emeraude-Client-Seo-Results-SitemapUrl-ChangeFrequency'></a>
### ChangeFrequency `property`

##### Summary

Frequency of changing for current page.

<a name='P-Definux-Emeraude-Client-Seo-Results-SitemapUrl-LastModification'></a>
### LastModification `property`

##### Summary

Date of last modification of the page.

<a name='P-Definux-Emeraude-Client-Seo-Results-SitemapUrl-Location'></a>
### Location `property`

##### Summary

Locaiton (URL) of the sitemap page.

<a name='P-Definux-Emeraude-Client-Seo-Results-SitemapUrl-Priority'></a>
### Priority `property`

##### Summary

Priority of the page for search engines.

<a name='T-Definux-Emeraude-Client-Seo-Extensions-ViewDataDictionaryExtensions'></a>
## ViewDataDictionaryExtensions `type`

##### Namespace

Definux.Emeraude.Client.Seo.Extensions

##### Summary

Extensions for [ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary').

<a name='M-Definux-Emeraude-Client-Seo-Extensions-ViewDataDictionaryExtensions-ApplyMetaTagsModel-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary,Definux-Emeraude-Client-Seo-Models-MetaTagsModel-'></a>
### ApplyMetaTagsModel(viewData,model) `method`

##### Summary

Apply specified [MetaTagsModel](#T-Definux-Emeraude-Client-Seo-Models-MetaTagsModel 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel') to the ViewData.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
| model | [Definux.Emeraude.Client.Seo.Models.MetaTagsModel](#T-Definux-Emeraude-Client-Seo-Models-MetaTagsModel 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel') |  |

<a name='M-Definux-Emeraude-Client-Seo-Extensions-ViewDataDictionaryExtensions-GetMetaTagsModelOrDefault-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetMetaTagsModelOrDefault(viewData) `method`

##### Summary

Gets defined meta tags from the page action.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |

<a name='M-Definux-Emeraude-Client-Seo-Extensions-ViewDataDictionaryExtensions-GetOrCreateCurrentMetaTagsModel-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary-'></a>
### GetOrCreateCurrentMetaTagsModel(viewData) `method`

##### Summary

Gets or creates [MetaTagsModel](#T-Definux-Emeraude-Client-Seo-Models-MetaTagsModel 'Definux.Emeraude.Client.Seo.Models.MetaTagsModel') into the ViewData.

##### Returns



##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| viewData | [Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary](#T-Microsoft-AspNetCore-Mvc-ViewFeatures-ViewDataDictionary 'Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary') |  |
