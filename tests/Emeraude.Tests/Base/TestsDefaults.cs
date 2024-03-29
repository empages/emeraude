﻿using System.Collections.Generic;
using Emeraude.Presentation.Converters;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Emeraude.Tests.Base;

public static class TestsDefaults
{
    public const string DefaultMediaType = "application/json";
        
    public static readonly JsonSerializerSettings JsonSerializerSettings = new JsonSerializerSettings()
    {
        ContractResolver = new DefaultContractResolver
        {
            NamingStrategy = new CamelCaseNamingStrategy(),
        },
        Formatting = Formatting.Indented,
        Converters = new List<JsonConverter>
        {
            new TimeSpanNewtonsoftConverter(),
            new TimeSpanNullableNewtonsoftConverter(),
            new DateModelNewtonsoftConverter(),
            new DateModelNullableNewtonsoftConverter(),
        }
    };
}