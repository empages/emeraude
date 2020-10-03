using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Helpers
{
    /// <summary>
    /// Abstract class that helps to be created custom data extraction for the purposes of UI element rendering.
    /// </summary>
    /// <typeparam name="TContext">Main database context of the application.</typeparam>
    public abstract class FormElementDatabaseView<TContext> : Dictionary<Guid, string>, IFormElementDatabaseView
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FormElementDatabaseView{TContext}"/> class.
        /// </summary>
        /// <param name="context"></param>
        public FormElementDatabaseView(TContext context)
        {
            this.Context = context;
            this.Init();
        }

        /// <summary>
        /// Database context of the application.
        /// </summary>
        public TContext Context { get; private set; }

        /// <summary>
        /// Method which contains the implementation of data extraction.
        /// </summary>
        protected abstract void Init();
    }
}
