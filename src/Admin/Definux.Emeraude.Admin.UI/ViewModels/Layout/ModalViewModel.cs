using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Admin.UI.ViewModels.Layout
{
    public class ModalViewModel
    {
        public ModalViewModel()
        {
            Buttons = new List<ModalActionButton>();
        }

        public string LunchButtonTitle { get; set; }

        public string LunchButtonIcon { get; set; }

        public string LunchButtonClasses { get; set; }

        public string ModalId { get; set; }

        public string Title { get; set; }

        public string Content { get; set; }

        public string ContentClass { get; set; }

        public bool IsContentHtml { get; set; }

        public string ModalHeaderClasses { get; set; }

        public string ModalBodyClasses { get; set; }

        public string ModalFooterClasses { get; set; }

        public ModalType Type { get; set; }

        public string TypeClass 
        { 
            get
            {
                switch (Type)
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

        public List<ModalActionButton> Buttons { get; set; }

        public bool HasCloseButton { get; set; }

        public struct ModalActionButton
        {
            public string Title { get; set; }

            public string Id { get; set; }

            public string Classes { get; set; }
        }

        public enum ModalType
        {
            Normal = 0,
            Small = 1,
            Large = 2
        }
    }
}
