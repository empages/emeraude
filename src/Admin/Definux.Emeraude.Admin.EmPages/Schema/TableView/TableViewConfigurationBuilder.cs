﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Definux.Emeraude.Domain.Entities;
using Definux.Emeraude.Essentials.Helpers;
using Definux.Utilities.Extensions;

namespace Definux.Emeraude.Admin.EmPages.Schema.TableView
{
    /// <summary>
    /// Table implementation of <see cref="IEmPageSchemaViewConfigurationBuilder{TViewItem,TEntity,TModel}"/>
    /// </summary>
    /// <typeparam name="TEntity">Domain entity.</typeparam>
    /// <typeparam name="TModel">EmPage model.</typeparam>
    public class TableViewConfigurationBuilder<TEntity, TModel> : IEmPageSchemaViewConfigurationBuilder<TableViewItem, TEntity, TModel>
        where TEntity : class, IEntity, new()
        where TModel : class, IEmPageModel, new()
    {
        private readonly List<TableViewItem> viewItems;

        /// <summary>
        /// Initializes a new instance of the <see cref="TableViewConfigurationBuilder{TEntity, TModel}"/> class.
        /// </summary>
        public TableViewConfigurationBuilder()
        {
            this.viewItems = new List<TableViewItem>();
            this.PageActions = new List<EmPageAction>
            {
                new ()
                {
                    Name = "Create",
                    RelativeUrlFormat = "/create",
                },
            };

            this.Breadcrumbs = new List<EmPageBreadcrumb>();
        }

        /// <inheritdoc/>
        public IReadOnlyList<TableViewItem> ViewItems => this.viewItems;

        /// <inheritdoc/>
        public IList<EmPageAction> PageActions { get; }

        /// <inheritdoc/>
        public IList<EmPageBreadcrumb> Breadcrumbs { get; }

        /// <inheritdoc/>
        public IEmPageSchemaViewConfigurationBuilder<TableViewItem, TEntity, TModel> Use(
            Expression<Func<TModel, object>> property,
            Action<TableViewItem> viewItemAction)
        {
            var memberInfo = ReflectionHelpers.GetCorrectPropertyMember(property);
            TableViewItem viewItem = new TableViewItem();
            viewItem.LoadSourceInfo(memberInfo as PropertyInfo);
            viewItemAction.Invoke(viewItem);

            if (this.ViewItems.Any(x => x.SourceName == viewItem.SourceName))
            {
                throw new ArgumentException($"Property {viewItem.SourceName} cannot be registered more than once.");
            }

            if (string.IsNullOrWhiteSpace(viewItem.Title))
            {
                viewItem.Title = viewItem.SourceName.SplitWordsByCapitalLetters();
            }

            if (viewItem.Order == -1)
            {
                viewItem.Order = this.ViewItems.Count;
            }

            this.viewItems.Add(viewItem);

            return this;
        }
    }
}