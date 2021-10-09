using System;
using System.Collections.Generic;
using System.Reflection;
using Definux.Emeraude.Admin.EmPages.UI.Components.Base;

namespace Definux.Emeraude.Admin.EmPages.Schema
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
            this.Parameters = new Dictionary<string, object>();
        }

        /// <inheritdoc/>
        public string Title { get; set; }

        /// <inheritdoc/>
        public int Order { get; set; } = -1;

        /// <inheritdoc/>
        public Type Component { get; private set; }

        /// <inheritdoc/>
        public IDictionary<string, object> Parameters { get; }

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
        public virtual void SetComponent<TComponent>()
            where TComponent : EmPageBaseElement, new()
        {
            this.Component = typeof(TComponent);
        }
    }
}