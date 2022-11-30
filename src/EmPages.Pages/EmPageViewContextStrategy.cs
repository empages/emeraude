using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using Essentials.Extensions;
using Essentials.Functions;

namespace EmPages.Pages;

/// <summary>
/// Abstract implementation of page view context strategy.
/// </summary>
/// <typeparam name="TViewItem">View item type.</typeparam>
/// <typeparam name="TModel">Model type.</typeparam>
public abstract class EmPageViewContextStrategy<TViewItem, TModel> : IEmPageViewContextStrategy<TViewItem, TModel>
    where TViewItem : class, IEmPageViewItem, new()
    where TModel : class, IEmPageModel, new()
{
    private readonly List<Func<IEnumerable<TModel>, EmPageRequest, EmAction>> actionsBuilders;
    private readonly List<TViewItem> viewItems;
    private readonly List<EmTypeDescription> customTypeDescriptions;
    private readonly List<(string TypeId, Func<EmPageRequest, IDictionary<object, string>> Func)> customTypeDescriptionsFuncs;

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageViewContextStrategy{TViewItem, TModel}"/> class.
    /// </summary>
    protected EmPageViewContextStrategy()
    {
        this.viewItems = new List<TViewItem>();
        this.actionsBuilders = new List<Func<IEnumerable<TModel>, EmPageRequest, EmAction>>();
        this.customTypeDescriptions = new List<EmTypeDescription>();
        this.customTypeDescriptionsFuncs =
            new List<(string TypeId, Func<EmPageRequest, IDictionary<object, string>> Func)>();
    }

    /// <inheritdoc/>
    public IReadOnlyList<IEmPageViewItem> ViewItems => this.viewItems;

    /// <inheritdoc/>
    public Type ViewItemType => typeof(TViewItem);

    /// <inheritdoc/>
    public IEnumerable<EmAction> GetPageActions(IEnumerable<IEmPageModel> models, EmPageRequest request) =>
        this.actionsBuilders.Select(x => x.Invoke(models.Select(m => m as TModel), request));

    /// <inheritdoc/>
    public string AddCustomTypeDescription(IDictionary<object, string> dictionary)
    {
        var typeId = EmPageUtilities.GenerateTypeId();
        this.customTypeDescriptions.Add(new EmTypeDescription
        {
            TypeId = typeId,
            Items = dictionary
                .Select(x => new EmTypeDescriptionItem
                {
                    Value = x.Key,
                    Name = x.Value,
                })
                .ToList(),
        });

        return typeId;
    }

    /// <inheritdoc/>
    public string AddCustomTypeDescription(Func<EmPageRequest, IDictionary<object, string>> typeDescriptionFunc)
    {
        var typeId = EmPageUtilities.GenerateTypeId();
        this.customTypeDescriptionsFuncs.Add((typeId, typeDescriptionFunc));
        return typeId;
    }

    /// <inheritdoc/>
    public void AddAction(Func<IEnumerable<TModel>, EmPageRequest, EmAction> actionBuilder)
    {
        this.actionsBuilders.Add(actionBuilder);
    }

    /// <inheritdoc/>
    public virtual IEmPageViewContextStrategy<TViewItem, TModel> Configure(
        Expression<Func<TModel, object>> property,
        Action<TViewItem> viewItemAction)
    {
        var memberInfo = ReflectionFunctions.GetCorrectPropertyMember(property);
        var viewItem = this.viewItems.FirstOrDefault(x => x.SourceName == memberInfo?.Name) ?? new TViewItem();

        viewItem.LoadSourceInfo(memberInfo as PropertyInfo);
        viewItemAction.Invoke(viewItem);

        if (string.IsNullOrWhiteSpace(viewItem.Label))
        {
            viewItem.Label = StringFunctions.SplitStringByCapitalLetters(viewItem.SourceName);
        }

        if (viewItem.Order == -1)
        {
            viewItem.Order = this.ViewItems.Count;
        }

        if (this.viewItems.All(x => x.SourceName != viewItem.SourceName))
        {
            this.viewItems.Add(viewItem);
        }

        return this;
    }

    /// <inheritdoc/>
    public IEmPageViewContextStrategy<TViewItem, TModel> Exclude(Expression<Func<TModel, object>> property)
    {
        var memberInfo = ReflectionFunctions.GetCorrectPropertyMember(property) as PropertyInfo;
        this.viewItems.RemoveAll(x => x.SourceName == memberInfo?.Name);

        return this;
    }

    /// <summary>
    /// Configure all properties of the model with the defaults set during the startup setup.
    /// </summary>
    /// <returns></returns>
    public IEmPageViewContextStrategy<TViewItem, TModel> ConfigureAll()
    {
        var modelProperties = EmPageUtilities.GetEmPageModelProperties(typeof(TModel));
        foreach (var propertyInfo in modelProperties)
        {
            var viewItem = this.viewItems.FirstOrDefault(x => x.SourceName == propertyInfo.Name) ?? new TViewItem();
            viewItem.LoadSourceInfo(propertyInfo);
            viewItem.SetDefaultComponent();

            if (string.IsNullOrWhiteSpace(viewItem.Label))
            {
                viewItem.Label = StringFunctions.SplitStringByCapitalLetters(viewItem.SourceName);
            }

            if (viewItem.Order == -1)
            {
                viewItem.Order = this.ViewItems.Count;
            }

            if (this.viewItems.All(x => x.SourceName != viewItem.SourceName))
            {
                this.viewItems.Add(viewItem);
            }
        }

        return this;
    }

    /// <inheritdoc/>
    public ICollection<EmTypeDescription> ExtractTypeDescriptions(EmPageRequest request)
    {
        var dictionaries = new HashSet<EmTypeDescription>();
        foreach (var viewItem in this.viewItems)
        {
            var viewItemType = viewItem.SourceType.GetTypeByIgnoreTheNullable();
            if (viewItemType.IsEnum)
            {
                var enumValues = EmPageUtilities.GetEnumDictionary(viewItemType);
                var typeId = EmPageUtilities.GenerateTypeId(viewItemType.FullName);
                if (dictionaries.Any(x => x.TypeId == typeId))
                {
                    continue;
                }

                dictionaries.Add(new EmTypeDescription
                {
                    TypeId = typeId,
                    Items = enumValues
                        .Select(x => new EmTypeDescriptionItem
                        {
                            Name = StringFunctions.SplitStringByCapitalLetters(x.Value),
                            Value = x.Key,
                        })
                        .ToHashSet(),
                });
            }
        }

        foreach (var typeDescription in this.customTypeDescriptions)
        {
            dictionaries.Add(typeDescription);
        }

        var requestBasedTypeDescriptions = this.BuildRequestBasedCustomTypeDescriptions(request);
        foreach (var typeDescription in requestBasedTypeDescriptions)
        {
            dictionaries.Add(typeDescription);
        }

        return dictionaries;
    }

    private IReadOnlyList<EmTypeDescription> BuildRequestBasedCustomTypeDescriptions(EmPageRequest request)
    {
        var typeDescriptions = new List<EmTypeDescription>();
        foreach (var customTypeDescriptionsFuncPair in this.customTypeDescriptionsFuncs)
        {
            var descriptionData = customTypeDescriptionsFuncPair.Func.Invoke(request);
            typeDescriptions.Add(new EmTypeDescription
            {
                TypeId = customTypeDescriptionsFuncPair.TypeId,
                Items = descriptionData
                    .Select(x => new EmTypeDescriptionItem
                    {
                        Value = x.Key,
                        Name = x.Value,
                    })
                    .ToList(),
            });
        }

        return typeDescriptions;
    }
}