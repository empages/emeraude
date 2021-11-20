using System;
using System.Collections.Generic;
using System.Reflection;
using Emeraude.Application.Admin.EmPages.Components;

namespace Emeraude.Application.Admin.EmPages.Schema
{
    /// <summary>
    /// Abstract implementation of <see cref="IViewItem"/>.
    /// </summary>
    public abstract class ViewItem : IViewItem
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ViewItem"/> class.
        /// </summary>
        protected ViewItem()
        {
        }

        /// <inheritdoc/>
        public string Title { get; set; }

        /// <inheritdoc/>
        public int Order { get; set; } = -1;

        /// <inheritdoc/>
        public EmPageComponent Component { get; private set; }

        /// <inheritdoc/>
        public object Parameters { get; private set; }

        /// <inheritdoc/>
        public string SourceName { get; private set; }

        /// <inheritdoc/>
        public Type SourceType { get; private set; }

        /// <inheritdoc/>
        public void LoadSourceInfo(PropertyInfo propertyInfo)
        {
            this.SourceName = propertyInfo.Name;
            this.SourceType = propertyInfo.PropertyType;
        }

        /// <inheritdoc/>
        public virtual void SetComponent<TComponent>(Action<TComponent> componentAction = null)
            where TComponent : EmPageComponent, new()
        {
            var component = new TComponent();
            componentAction?.Invoke(component);
            this.Component = component;
            this.Component.SourceType = this.SourceType;
            this.Parameters = this.Component.GetParametersObject();
        }
    }
}