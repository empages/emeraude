using System;
using Definux.Emeraude.Client.Models;
using Microsoft.AspNetCore.Mvc.ViewFeatures;

namespace Definux.Emeraude.Client.Extensions
{
    /// <summary>
    /// Extensions for <see cref="ViewDataDictionary"/>.
    /// </summary>
    public static class ViewDataDictionaryExtensions
    {
        private const string ViewDataMetaTagsModelKey = "MetaTagsModel";

        /// <summary>
        /// Gets defined meta tags from the page action.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static MetaTagsModel GetMetaTagsModelOrDefault(this ViewDataDictionary viewData)
        {
            try
            {
                return viewData.ContainsKey(ViewDataMetaTagsModelKey) ? (MetaTagsModel)viewData[ViewDataMetaTagsModelKey] : null;
            }
            catch (Exception)
            {
                return null;
            }
        }

        /// <summary>
        /// Gets or creates <see cref="MetaTagsModel"/> into the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <returns></returns>
        public static MetaTagsModel GetOrCreateCurrentMetaTagsModel(this ViewDataDictionary viewData)
        {
            MetaTagsModel result = new MetaTagsModel();

            try
            {
                if (viewData.ContainsKey(ViewDataMetaTagsModelKey) && viewData[ViewDataMetaTagsModelKey] != null)
                {
                    result = (MetaTagsModel)viewData[ViewDataMetaTagsModelKey];
                }
            }
            catch (Exception)
            {
                result = new MetaTagsModel();
            }
            finally
            {
                viewData[ViewDataMetaTagsModelKey] = result;
            }

            return result;
        }

        /// <summary>
        /// Apply specified <see cref="MetaTagsModel"/> to the ViewData.
        /// </summary>
        /// <param name="viewData"></param>
        /// <param name="model"></param>
        public static void ApplyMetaTagsModel(this ViewDataDictionary viewData, MetaTagsModel model)
        {
            viewData[ViewDataMetaTagsModelKey] = model;
        }
    }
}
