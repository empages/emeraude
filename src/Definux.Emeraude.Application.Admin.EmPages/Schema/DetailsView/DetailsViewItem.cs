using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Application.Admin.EmPages.Schema.DetailsView
{
    /// <summary>
    /// Details view item of <see cref="IEmPageSchema{TModel}"/>.
    /// </summary>
    public class DetailsViewItem : ViewItem, IValuePipedViewItem
    {
        private readonly List<(Type, string[])> valuePipes;

        /// <summary>
        /// Initializes a new instance of the <see cref="DetailsViewItem"/> class.
        /// </summary>
        public DetailsViewItem()
        {
            this.valuePipes = new List<(Type, string[])>();
        }

        /// <inheritdoc/>
        public IReadOnlyList<(Type, string[])> ValuePipes => this.valuePipes;

        /// <inheritdoc/>
        public void AddValuePipe<TValuePipe>(params string[] parameters)
            where TValuePipe : class, IValuePipe
        {
            this.valuePipes.Add((typeof(TValuePipe), parameters));
        }
    }
}