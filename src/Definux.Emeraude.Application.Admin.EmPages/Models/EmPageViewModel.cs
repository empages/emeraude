using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using Definux.Emeraude.Application.Admin.EmPages.Components;
using Definux.Emeraude.Essentials.Models;

namespace Definux.Emeraude.Application.Admin.EmPages.Models
{
    /// <summary>
    /// Main EmPage model in the context of UI.
    /// </summary>
    public abstract class EmPageViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="EmPageViewModel"/> class.
        /// </summary>
        /// <param name="context"></param>
        protected EmPageViewModel(EmPageViewContext context)
        {
            this.PropertyComponentMap = new List<PropertyMap<EmPageComponent>>();
            this.PropertyParametersMap = new List<PropertyMap<IEnumerable<Parameter>>>();
            this.PropertyOrderMap = new List<PropertyMap<int>>();
            this.ModelEnumerations = new Dictionary<string, IEnumerable<EnumValueItem>>();
            this.Context = context;
        }

        /// <inheritdoc cref="EmPageViewContext"/>
        public EmPageViewContext Context { get; set; }

        /// <summary>
        /// Pair that contains corresponding component for each property of the model.
        /// </summary>
        public IList<PropertyMap<EmPageComponent>> PropertyComponentMap { get; }

        /// <summary>
        /// Pair that contains corresponding parameters for each property of the model.
        /// </summary>
        public IList<PropertyMap<IEnumerable<Parameter>>> PropertyParametersMap { get; }

        /// <summary>
        /// Pair that contains enumerations per type name for all properties of the model.
        /// </summary>
        public IDictionary<string, IEnumerable<EnumValueItem>> ModelEnumerations { get; }

        /// <summary>
        /// Pair that contains corresponding orders for each property of the model.
        /// </summary>
        public IList<PropertyMap<int>> PropertyOrderMap { get; }
    }
}