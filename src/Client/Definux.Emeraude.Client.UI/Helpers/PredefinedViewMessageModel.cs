using System;
using System.Collections.Generic;
using System.Text;

namespace Definux.Emeraude.Client.UI.Helpers
{
    /// <summary>
    /// Model used for notification message on predefined views.
    /// </summary>
   public class PredefinedViewMessageModel
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="PredefinedViewMessageModel"/> class.
        /// </summary>
        /// <param name="targetView"></param>
        /// <param name="documentationLink"></param>
        public PredefinedViewMessageModel(string targetView, string documentationLink)
        {
            this.TargetView = targetView;
            this.DocumentationLink = documentationLink;
        }

        /// <summary>
        /// Name of the view.
        /// </summary>
        public string TargetView { get; set; }

        /// <summary>
        /// Link for documentation of current view.
        /// </summary>
        public string DocumentationLink { get; set; }
    }
}
