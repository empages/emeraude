using System;
using System.Collections.Generic;

namespace Definux.Emeraude.Admin.EmPages
{
    /// <summary>
    /// Table view item of <see cref="IEmPageSchema{Entity, Model}"/>.
    /// </summary>
    public class TableViewItem : ViewItem, IValuePipedViewItem
    {
        private readonly List<(Type, string[])> valuePipes;

        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewItem"/> class.
        /// </summary>
        public TableViewItem()
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