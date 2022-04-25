﻿using System.Linq;

namespace Emeraude.Pages;

/// <summary>
/// Page route segment.
/// </summary>
public class EmPageRouteSegment
{
    private const string DynamicSegmentStartSymbol = "{";
    private const string DynamicSegmentEndSymbol = "}";
    private const string AllowedSegmentSymbols = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ123456789-~";

    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageRouteSegment"/> class.
    /// </summary>
    /// <param name="rawValue"></param>
    public EmPageRouteSegment(string rawValue)
    {
        if (string.IsNullOrWhiteSpace(rawValue))
        {
            throw new EmSetupException($"Route segment cannot be null or empty");
        }

        if (rawValue.StartsWith(DynamicSegmentStartSymbol) && rawValue.EndsWith(DynamicSegmentEndSymbol))
        {
            this.Dynamic = true;
            this.Value = rawValue.Substring(1, rawValue.Length - 2);
        }
        else
        {
            this.Value = rawValue;
        }

        var allowedSegmentsSymbols = AllowedSegmentSymbols.ToCharArray();
        if (!this.Value.All(x => allowedSegmentsSymbols.Contains(x)))
        {
            throw new EmSetupException($"Route segment must be built only with the following symbols: {AllowedSegmentSymbols}");
        }
    }

    /// <summary>
    /// Flag that indicates whether the segment is dynamic or static.
    /// </summary>
    public bool Dynamic { get; }

    /// <summary>
    /// Value of the segment.
    /// </summary>
    public string Value { get; }
}