using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Reflection;
using Definux.Emeraude.Admin.EmPages.UI.Models;
using Definux.Emeraude.Essentials.Helpers;

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
        /// Placeholder that is replaced with model property.
        /// </summary>
        public const string ModelProperty = "[[Model:{0}]]";

        /// <summary>
        /// Gets model property placeholder.
        /// </summary>
        /// <param name="property"></param>
        /// <typeparam name="TModel">Target model.</typeparam>
        /// <returns></returns>
        public static string GetModelPlaceholder<TModel>(Expression<Func<TModel, object>> property)
        {
            var propertyInfo = ReflectionHelpers.GetCorrectPropertyMember(property) as PropertyInfo;
            return string.Format(ModelProperty, propertyInfo?.Name ?? "Id");
        }

        /// <summary>
        /// Applies model properties from placeholder if exists.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="model"></param>
        /// <param name="convertedContent"></param>
        /// <returns></returns>
        public static bool TryApplyModelPropertiesPlaceholders(
            string content,
            object model,
            out string convertedContent)
        {
            var modelType = model.GetType();
            var properties = modelType.GetProperties();
            bool succeeded = false;
            convertedContent = content;
            foreach (var property in properties)
            {
                string currentPlaceholder = string.Format(ModelProperty, property.Name);
                if (content.Contains(currentPlaceholder))
                {
                    convertedContent = convertedContent.Replace(currentPlaceholder, property.GetValue(model)?.ToString());
                    succeeded = true;
                }
            }

            return succeeded;
        }

        /// <summary>
        /// Applies model properties from placeholder if exists.
        /// </summary>
        /// <param name="content"></param>
        /// <param name="fields"></param>
        /// <param name="convertedContent"></param>
        /// <returns></returns>
        public static bool TryApplyModelPropertiesPlaceholders(
            string content,
            IDictionary<string, object> fields,
            out string convertedContent)
        {
            bool succeeded = false;
            convertedContent = content;
            foreach (var (name, value) in fields)
            {
                string currentPlaceholder = string.Format(ModelProperty, name);
                if (content.Contains(currentPlaceholder))
                {
                    convertedContent = convertedContent.Replace(currentPlaceholder, value?.ToString());
                    succeeded = true;
                }
            }

            return succeeded;
        }

        /// <summary>
        /// Get form action from placeholder if exists.
        /// </summary>
        /// <param name="placeholder"></param>
        /// <param name="formType"></param>
        /// <param name="resultPlaceholder"></param>
        /// <returns></returns>
        public static bool TryGetFormActionPlaceholder(
            string placeholder,
            EmPageFormType formType,
            out string resultPlaceholder)
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