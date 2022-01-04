<img align="left" width="300px" style="background-color:white;" title="Emeraude" alt="Emeraude" src="https://raw.githubusercontent.com/emeraudeframework/emeraude/master/art/logo_text.svg" />

<br/>

# Emeraude Framework
### A lightweight ASP.NET framework for creating successful products

![.NET Core](https://github.com/emeraudeframework/emeraude/workflows/.NET%20Core/badge.svg)
[![Build status](https://ci.appveyor.com/api/projects/status/8mkn54s6fauem0lb?svg=true)](https://ci.appveyor.com/project/gsk567/emeraude)
![Nuget](https://img.shields.io/nuget/v/Emeraude)

---

### For detailed explanation please check our [DOCUMENTATION](https://emeraude.dev)

---

Emeraude is a web application framework based on ASP.NET which is delivered in the form of NuGet packages
that anyone can import into the project that working on. The framework can be considered as separated and
relatively independent because its main goal is to provide additional features by minor impact over the
application.
For a more clear view of the framework let's describe what Emeraude is/does and what Emeraude is/does not:

- Emeraude is based on ASP.NET
- Emeraude is written on .NET 6 and C# 10
- Emeraude is a framework - not a library
- Emeraude is a wrapper for an ASP.NET-based web application
- Emeraude can be used for all type web projects - MVC, Web API, RazorPages, Blazor, etc.
- Emeraude provides abstractions, services and utilities out of the box
- Emeraude is configurable
- Emeraude is free and open-source
- Emeraude does not require any licenses and keys to work
- Emeraude does not have any requirements for your application code
- Emeraude does not wrap any UI-related elements (HTML, CSS, JS) into its NuGet packages
- Emeraude is not a CMS, CRM, etc.
- Emeraude is not SaaS, PaaS, etc.

## Features

Emeraude Framework is following the principle 'Less is More' so the list of the features is significantly small:

#### EmPages

EmPage (Emeraude Page) is the core feature of the framework. Its purpose is to provide to the Emeraude users ability to
create complete feature of any kind with minimal effort. EmPage can be considered as sub feature of the administration
part of the framework because from management point of view the framework is design to provide powerful, private and
secure solution for control of internal and external data flows.

#### Runtime Generation

In order to provide maximum productivity to the developers Emeraude has built-in tool called **Client Builder**.
The tool is constructed by 2 main elements - back-end element represented by Scaffold Modules and front-end element
represented by the Emeraude Portal.

#### Authentication

Authentication is split on two - integrated authentication which is a part of the Portal Gateway or pluggable authentication
which is a part of the Platform Base. Both are consuming the Identity instance of the Application layer.

#### Localization

Localization is a main feature of the framework that is useful if you're considering to use Emeraude as a core base of
your application. The feature itself is split on few parts - one core that is placed in the infrastructure and another
consumable in the presentation. Everything related to the localization is stored in separated SQLite database and managed
by the LocalizationContext. By using the Client Builder module of Emeraude Portal you have management capabilities for the
LocalizationContext.

#### System Files Management

In order to simplify the usage with files of the application folder Emeraude Framework provides separate instance of the
infrastructure designed to fit the requirements of the system file management.

#### SEO

Search Engine Optimization cannot be provided as a feature because it is a result of hard work during the development of
any application. But to help you during the development of your application Emeraude provides you sitemap generator and
easy way to generate friendly localized URLs.

#### Utilities

We know that during development of any application sometimes developers needs utilities for boosting the performance and
making the code cleaner. Emeraude Framework in addition to the context based features provides static utility classes and
methods by referencing the **Emeraude.Essentials**. That assembly is mainly used by the framework itself, but you can use
it if you see it useful.

## Emeraude Portal

Emeraude Portal is separated product maintained by the Emeraude team. Its idea is to provide ready to use client that
is deployed separately of your application and consume the Portal Gateway of your application. Our main purpose is instead to
provide you integrated client transported with the packages or separated desktop application that you need to install on
your machine, just to link your application with the portal that is accessible on [emeraude.io](https://emeraude.io).
More about the Emeraude Portal can be found on the [emeraude.io](https://emeraude.io).

## Business Applications

The proper usage of the Emeraude is very important for the stability of your application and respectively product.
The framework is designed to provide management capabilities and supporting abstractions, services, and utilities
for your application.

Consider the fact Emeraude Portal is made to support you, your team members, and the stakeholders  - not the users of
the application.

The usage of the Emeraude is not limited to a specific domain. A few possible examples are:

- Website
- Web application
- Web API
- CMS, CRM, ERP
- Mobile/desktop application data/users manager
- Microservices data manager
- Unified third-parties manager
- Source code analysis platform

## Sponsors

<div class="sponsors-list-item" style="background: white">
    <a class="feature-list-item m-3" style="display: inline-block;" title="JetBrains" target="_blank" href="https://www.jetbrains.com/?from=Emeraude" data-v-94bffd70="">
        <img src="https://emeraude.dev/_assets/images/sponsors/jetbrains.svg" alt="JetBrains" data-v-94bffd70="">
    </a>
    <a class="feature-list-item m-3" style="display: inline-block;" title="Netlify" target="_blank" href="https://www.netlify.com/?reference=emeraude.dev" data-v-94bffd70="">
        <img src="https://emeraude.dev/_assets/images/sponsors/netlify.svg" alt="Netlify" data-v-94bffd70="">
    </a>
</div>

## Support Us

<div id="support" data-v-6ad604c2="" data-v-3cfc6c66="">
    <div class="donate-section" data-v-3cfc6c66="">
        <a href="https://www.paypal.com/donate?hosted_button_id=4FEAXAP5TL3EG" class="btn btn-lg btn-outline-light mx-1"
            target="_blank" data-v-3cfc6c66="">Donate via PayPal</a>
        <br />
        <a href="https://www.patreon.com/gsk567" class="btn btn-lg btn-outline-light mx-1" target="_blank"
            data-v-3cfc6c66="">Become a backer or sponsor via Patreon</a>
    </div>
</div>

<p class="my-4 px-2"> Apache License 2.0 • Copyright © 2022 <a href="https://georgi.karagogov.com/" target="_blank">Georgi Karagogov</a></p>