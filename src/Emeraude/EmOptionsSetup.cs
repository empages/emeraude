﻿using Emeraude.Application;
using Emeraude.Application.Admin;
using Emeraude.Application.Admin.Options;
using Emeraude.Application.ClientBuilder.Options;
using Emeraude.Application.Consumer;
using Emeraude.Application.Consumer.Options;
using Emeraude.Application.Options;
using Emeraude.Configuration.Options;
using Emeraude.Infrastructure.FileStorage;
using Emeraude.Infrastructure.FileStorage.Options;
using Emeraude.Infrastructure.Identity.Options;
using Emeraude.Infrastructure.Localization;
using Emeraude.Infrastructure.Localization.Options;
using Emeraude.Infrastructure.Persistence;
using Emeraude.Infrastructure.Persistence.Options;
using Emeraude.Presentation;
using Emeraude.Presentation.Options;
using Emeraude.Presentation.PortalGateway;
using Emeraude.Presentation.PortalGateway.Options;

namespace Emeraude;

/// <summary>
/// Setup class that contains reference to all available options in Emeraude Framework.
/// </summary>
public class EmOptionsSetup
{
    /// <inheritdoc cref="EmMainOptions" />
    public EmMainOptions MainOptions { get; set; } = new ();

    /// <inheritdoc cref="EmApplicationsOptions" />
    public EmApplicationsOptions ApplicationsOptions { get; set; } = new ();

    /// <inheritdoc cref="EmPresentationOptions" />
    public EmPresentationOptions PresentationOptions { get; set; } = new ();

    /// <inheritdoc cref="EmAdminOptions" />
    public EmAdminOptions AdminOptions { get; set; } = new ();

    /// <inheritdoc cref="EmConsumerOptions" />
    public EmConsumerOptions ConsumerOptions { get; set; } = new ();

    /// <inheritdoc cref="EmPersistenceOptions" />
    public EmPersistenceOptions PersistenceOptions { get; set; } = new ();

    /// <inheritdoc cref="EmIdentityOptions" />
    public EmIdentityOptions IdentityOptions { get; set; } = new ();

    /// <inheritdoc cref="EmLocalizationOptions" />
    public EmLocalizationOptions LocalizationOptions { get; set; } = new ();

    /// <inheritdoc cref="EmFilesOptions" />
    public EmFilesOptions FilesOptions { get; set; } = new ();

    /// <inheritdoc cref="EmClientBuilderOptions" />
    public EmClientBuilderOptions ClientBuilderOptions { get; set; } = new ();

    /// <inheritdoc cref="EmPortalGatewayOptions" />
    public EmPortalGatewayOptions PortalGatewayOptions { get; set; } = new ();
}