using System;
using Emeraude.Application.Admin.EmPages.Components;
using Emeraude.Application.Admin.EmPages.Exceptions;
using Emeraude.Application.Admin.EmPages.Shared;
using Emeraude.Essentials.Extensions;

namespace Emeraude.Application.Admin.EmPages.Schema.FormView
{
    /// <summary>
    /// Form view item of <see cref="IEmPageSchema{TModel}"/>.
    /// </summary>
    public class FormViewItem : ViewItem
    {
        private Type selectableCustomDataSourceType = null;

        /// <summary>
        /// Type of the form view item.
        /// </summary>
        public FormViewItemType Type { get; set; }

        /// <summary>
        /// Property that notify the client's view that field is required.
        /// </summary>
        public bool Required { get; set; }

        /// <summary>
        /// Blocks current view item for mutation via the form.
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// Flag that indicates whether the item could be null or not.
        /// </summary>
        public bool IsNullable => this.SourceType?.IsNullableType() ?? false;

        /// <summary>
        /// Type of the selectable custom data source.
        /// </summary>
        public Type SelectableCustomDataSourceType => this.selectableCustomDataSourceType;

        /// <summary>
        /// Includes selectable custom data source to the current view item.
        /// </summary>
        /// <typeparam name="TSource">Type of <see cref="IFormViewSelectableCustomDataSource"/>.</typeparam>
        public void IncludeSelectableCustomDataSource<TSource>()
            where TSource : class, IFormViewSelectableCustomDataSource
        {
            this.selectableCustomDataSourceType = typeof(TSource);
        }

        /// <summary>
        /// <inheritdoc cref="SetComponent{TComponent}"/>
        /// </summary>
        /// <param name="componentAction"></param>
        /// <typeparam name="TComponent">Component type that must be instance of <see cref="EmPageComponent"/> if view item is not set to readonly via <see cref="Readonly"/>.</typeparam>
        /// <exception cref="InvalidCastException">Throws when the view item is not set to readonly via <see cref="Readonly"/> and component type is not <see cref="EmPageBaseFormElement"/>.</exception>
        public override void SetComponent<TComponent>(Action<TComponent> componentAction = null)
        {
            if (!this.Readonly)
            {
                var tempInstance = Activator.CreateInstance<TComponent>();
                if (tempInstance.Type != EmPageComponentType.Mutator)
                {
                    throw new EmPageInvalidSchemaDefinitionException("You cannot use renderer component for not readonly form view items");
                }
            }

            this.InitializeComponent(componentAction, component =>
            {
                component.SourceType = this.SelectableCustomDataSourceType ?? component.SourceType;
            });
        }
    }
}