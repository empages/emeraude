using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.UI.UIElements.Form.Helpers
{
    public abstract class FormElementDatabaseView<TContext> : Dictionary<Guid, string>, IFormElementDatabaseView
    {
        protected readonly TContext context;

        public FormElementDatabaseView(TContext context)
        {
            this.context = context;
            Init();
        }

        protected abstract void Init();
    }
}
