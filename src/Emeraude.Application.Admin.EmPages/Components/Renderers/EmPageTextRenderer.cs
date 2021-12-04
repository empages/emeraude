using System;
using Emeraude.Application.Admin.EmPages.Shared;

namespace Emeraude.Application.Admin.EmPages.Components.Renderers;

/// <summary>
/// This component can be used to be visualized any type of data (text, numbers, dates, etc.).
/// </summary>
public class EmPageTextRenderer : EmPageComponent
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageTextRenderer"/> class.
    /// </summary>
    public EmPageTextRenderer()
        : base(EmPageComponentType.Renderer)
    {
    }

    /// <summary>
    /// Function that contains logic for formatting the value.
    /// </summary>
    public string FormatFunction { get; set; }
}