using System.Collections.Generic;
using System.Linq.Expressions;

namespace Emeraude.Essentials.Helpers;

/// <summary>
/// Implementation of replacer for expression parameter.
/// </summary>
internal class ExpressionParameterReplacer : ExpressionVisitor
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ExpressionParameterReplacer"/> class.
    /// </summary>
    /// <param name="fromParameters"></param>
    /// <param name="toParameters"></param>
    internal ExpressionParameterReplacer(IList<ParameterExpression> fromParameters, IList<ParameterExpression> toParameters)
    {
        this.ParameterReplacements = new Dictionary<ParameterExpression, ParameterExpression>();

        for (int i = 0; i != fromParameters.Count && i != toParameters.Count; i++)
        {
            this.ParameterReplacements.Add(fromParameters[i], toParameters[i]);
        }
    }

    private IDictionary<ParameterExpression, ParameterExpression> ParameterReplacements { get; set; }

    /// <inheritdoc/>
    protected override Expression VisitParameter(ParameterExpression node)
    {
        ParameterExpression replacement;

        if (this.ParameterReplacements.TryGetValue(node, out replacement))
        {
            node = replacement;
        }

        return base.VisitParameter(node);
    }
}