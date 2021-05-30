using System.Collections.Generic;
using Definux.Emeraude.Admin.UI.Utilities;

namespace Definux.Emeraude.Admin.UI.ViewModels.Layout
{
    /// <summary>
    /// ViewModel that complements the '_Modal' partial.
    /// </summary>
    public class ModalViewModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModalViewModel"/> class.
        /// </summary>
        public ModalViewModel()
        {
            this.Buttons = new List<ModalActionButton>();
        }

        /// <summary>
        /// Title text of the button that lunch the modal.
        /// </summary>
        public string LunchButtonTitle { get; set; }

        /// <summary>
        /// Icon of the button that lunch the modal.
        /// </summary>
        public string LunchButtonIcon { get; set; }

        /// <summary>
        /// Classes of the button that lunch the modal.
        /// </summary>
        public string LunchButtonClasses { get; set; }

        /// <summary>
        /// Identification of the modal.
        /// </summary>
        public string ModalId { get; set; }

        /// <summary>
        /// Title text of the modal.
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        /// Content of the modal.
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// Content class of the modal.
        /// </summary>
        public string ContentClass { get; set; }

        /// <summary>
        /// Flag that indicates whether the content is raw text or HTML.
        /// </summary>
        public bool IsContentHtml { get; set; }

        /// <summary>
        /// Classes of the modal header.
        /// </summary>
        public string ModalHeaderClasses { get; set; }

        /// <summary>
        /// Classes of the modal body.
        /// </summary>
        public string ModalBodyClasses { get; set; }

        /// <summary>
        /// Classes of the modal footer.
        /// </summary>
        public string ModalFooterClasses { get; set; }

        /// <inheritdoc cref="ModalType"/>
        public ModalType Type { get; set; }

        /// <summary>
        /// Modal type class based on the modal type.
        /// </summary>
        public string TypeClass
        {
            get
            {
                switch (this.Type)
                {
                    case ModalType.Normal:
                        return " ";
                    case ModalType.Small:
                        return " modal-sm";
                    case ModalType.Large:
                        return " modal-lg";
                    default:
                        return " ";
                }
            }
        }

        /// <summary>
        /// List of all action buttons of the modal.
        /// </summary>
        public List<ModalActionButton> Buttons { get; set; }

        /// <summary>
        /// Flag that show/hide the close button of the modal.
        /// </summary>
        public bool HasCloseButton { get; set; }

        /// <summary>
        /// Struct that represent the action button of the modal.
        /// </summary>
        public struct ModalActionButton
        {
            /// <summary>
            /// Title text of the button.
            /// </summary>
            public string Title { get; set; }

            /// <summary>
            /// Identificator of the button.
            /// </summary>
            public string Id { get; set; }

            /// <summary>
            /// Style classes of the button.
            /// </summary>
            public string Classes { get; set; }
        }
    }
}
