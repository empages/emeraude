using System;
using Definux.Emeraude.Admin.EmPages.UI.Components.Base;

namespace Definux.Emeraude.Admin.EmPages.Schema.FormView
{
    /// <summary>
    /// Form view item of <see cref="IEmPageSchema{TEntity, TModel}"/>.
    /// </summary>
    public class FormViewItem : ViewItem
    {
        /// <summary>
        /// Type of the form view item.
        /// </summary>
        public FormViewItemType Type { get; set; }

        /// <summary>
        /// Property that place required indicator on the current view item when value is set to 'true'.
        /// That property does not have influence to the validation of the form.
        /// </summary>
        public bool RequiredIndicator { get; set; }

        /// <summary>
        /// Blocks current view item for mutation via the form.
        /// </summary>
        public bool Readonly { get; set; }

        /// <summary>
        /// <inheritdoc cref="SetComponent{TComponent}"/>
        /// </summary>
        /// <typeparam name="TComponent">Component type that must be instance of <see cref="EmPageBaseFormElement"/> if view item is not set to readonly via <see cref="Readonly"/>.</typeparam>
        /// <exception cref="InvalidCastException">Throws when the view item is not set to readonly via <see cref="Readonly"/> and component type is not <see cref="EmPageBaseFormElement"/>.</exception>
        public override void SetComponent<TComponent>()
        {
            if (!this.Readonly)
            {
                var tempInstance = Activator.CreateInstance<TComponent>();
                if (!(tempInstance is EmPageBaseFormElement))
                {
                    throw new InvalidCastException("The provided component type cannot be casted to EmPageBaseFormElement.");
                }
            }

            base.SetComponent<TComponent>();
        }
    }
}