using System;
using Definux.Emeraude.Admin.EmPages.UI.Models;

namespace Definux.Emeraude.Admin.EmPages.UI.Utilities
{
    /// <summary>
    /// List of built-in placeholders used by the EmPages.
    /// </summary>
    public static class EmPagesPlaceholders
    {
        /// <summary>
        /// Placeholder that is replaced with the current form action.
        /// </summary>
        public const string FormAction = "[[FormAction]]";

        /// <summary>
        /// Get form action from placeholder if exists.
        /// </summary>
        /// <param name="placeholder"></param>
        /// <param name="formType"></param>
        /// <param name="resultPlaceholder"></param>
        /// <returns></returns>
        public static bool TrySetFormAction(string placeholder, EmPageFormType formType, out string resultPlaceholder)
        {
            if (!FormAction.Equals(placeholder))
            {
                resultPlaceholder = placeholder;
                return false;
            }

            switch (formType)
            {
                case EmPageFormType.CreateForm:
                    resultPlaceholder = "Create";
                    return true;
                case EmPageFormType.EditForm:
                    resultPlaceholder = "Edit";
                    return true;
                default:
                    resultPlaceholder = placeholder;
                    return false;
            }
        }
    }
}