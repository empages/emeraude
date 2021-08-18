using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.UIElements
{
    /// <summary>
    /// Abstract class that helps to be created custom data extraction for the purposes of UI element rendering.
    /// </summary>
    /// <typeparam name="TContext">Main database context of the application.</typeparam>
    public abstract class CustomEntityDataPair<TContext> : Dictionary<Guid, string>, ICustomEntityDataPair
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CustomEntityDataPair{TContext}"/> class.
        /// </summary>
        /// <param name="context"></param>
        public CustomEntityDataPair(TContext context)
        {
            this.Context = context;
            this.LoadData();
        }

        /// <summary>
        /// Database context of the application.
        /// </summary>
        public TContext Context { get; private set; }

        /// <summary>
        /// Method which contains the implementation of data extraction.
        /// </summary>
        protected abstract void LoadData();
    }
}
