using System;
using System.Linq;
using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Utilities;

/// <summary>
/// Instance of feature route segments wrapper.
/// </summary>
public class EmPageFeatureRoute
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageFeatureRoute"/> class.
    /// </summary>
    /// <param name="featureSegments"></param>
    public EmPageFeatureRoute(string[] featureSegments)
    {
        this.FeatureSegments = featureSegments ?? throw new ArgumentNullException(nameof(featureSegments));
    }

    /// <summary>
    /// Feature route segments.
    /// </summary>
    public string[] FeatureSegments { get; set; }

    /// <summary>
    /// Id of the model.
    /// </summary>
    public Guid? ModelId
    {
        get
        {
            if (Guid.TryParse(this.FeatureSegments?.FirstOrDefault() ?? string.Empty, out var modelId))
            {
                return modelId;
            }

            return null;
        }
    }

    /// <summary>
    /// Gets route type.
    /// </summary>
    /// <param name="notUsedSegments"></param>
    /// <returns></returns>
    public EmPageRouteType? GetRouteType(out string[] notUsedSegments)
    {
        var segmentsCount = this.FeatureSegments?.Length ?? 0;
        if (segmentsCount == 0)
        {
            notUsedSegments = new string[] { };
            return EmPageRouteType.Table;
        }

        if (segmentsCount > 0 && this.FeatureSegments.First().Contains("create", StringComparison.OrdinalIgnoreCase))
        {
            notUsedSegments = this.FeatureSegments.Skip(1).ToArray();
            return EmPageRouteType.Create;
        }

        if (this.ModelId.HasValue && segmentsCount > 1 && this.FeatureSegments.ElementAt(1).Contains("edit", StringComparison.OrdinalIgnoreCase))
        {
            notUsedSegments = this.FeatureSegments.Skip(2).ToArray();
            return EmPageRouteType.Edit;
        }

        if (this.ModelId.HasValue)
        {
            notUsedSegments = this.FeatureSegments.Skip(1).ToArray();
            return EmPageRouteType.Details;
        }

        notUsedSegments = this.FeatureSegments;
        return null;
    }
}