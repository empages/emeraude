using System.Reflection;
using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Schema.DetailsView;

/// <summary>
/// Relation instance that contains relation configuration between parent and target EmPage models in the context of feature.
/// </summary>
public class EmPageFeatureSourceToParentRelation
{
    /// <summary>
    /// Property of the parent model.
    /// </summary>
    public PropertyInfo ParentProperty { get; set; }

    /// <summary>
    /// Property of the target model.
    /// </summary>
    public PropertyInfo SourceProperty { get; set; }

    /// <summary>
    /// Reference direction of the relation.
    /// </summary>
    public EmPageFeatureReferenceDirection ReferenceDirection { get; set; }
}