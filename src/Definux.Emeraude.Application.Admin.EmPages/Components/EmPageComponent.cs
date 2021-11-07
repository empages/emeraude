using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Definux.Emeraude.Application.Admin.EmPages.Shared;
using Definux.Emeraude.Essentials.Helpers;

namespace Definux.Emeraude.Application.Admin.EmPages.Components
{
    /// <summary>
    /// Abstract implementation of EmPage component.
    /// </summary>
    public abstract class EmPageComponent
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageComponent"/> class.
        /// </summary>
        /// <param name="type"></param>
        public EmPageComponent(EmPageComponentType type)
        {
            this.Type = type;
        }

        /// <summary>
        /// Name of the component in the UI provider source.
        /// </summary>
        public string SourceName => this.GetType().Name;

        /// <summary>
        /// Type of the component.
        /// </summary>
        public EmPageComponentType Type { get; }

        /// <summary>
        /// Type of the source.
        /// </summary>
        [JsonIgnore]
        public Type SourceType { get; set; }

        /// <summary>
        /// Full name of the source type.
        /// </summary>
        public string SourceTypeName => ReflectionHelpers.GetTypeByIgnoreTheNullable(this.SourceType).FullName;

        /// <summary>
        /// Flag that indicates whether the source type is nullable or not.
        /// </summary>
        public bool IsNullable => Nullable.GetUnderlyingType(this.SourceType) != null;
    }
}