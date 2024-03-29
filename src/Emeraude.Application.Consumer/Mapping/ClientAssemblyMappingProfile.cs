﻿using Emeraude.Application.Mapping;

namespace Emeraude.Application.Consumer.Mapping;

/// <summary>
/// Assembly mapping profile for registration of all mappings configurations for administration.
/// </summary>
public class ClientAssemblyMappingProfile : AssemblyMappingProfile
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ClientAssemblyMappingProfile"/> class.
    /// </summary>
    public ClientAssemblyMappingProfile()
        : base(System.Reflection.Assembly.GetExecutingAssembly())
    {
    }
}