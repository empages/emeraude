﻿using System.Collections.Generic;
using Emeraude.Application.Admin.EmPages.Schema.FormView;

namespace Emeraude.Application.Admin.EmPages.Models.FormView;

/// <summary>
/// Model implementation for form view.
/// </summary>
public class EmPageFormViewModel : EmPageViewModel
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageFormViewModel"/> class.
    /// </summary>
    /// <param name="context"></param>
    public EmPageFormViewModel(EmPageViewContext context)
        : base(context)
    {
        this.Inputs = new List<EmPageFormInputModel>();
        this.NonMappedFormErrors = new List<string>();
        this.ModelSelectableCustomDataMap = new Dictionary<string, IEnumerable<FormViewSelectableCustomDataItem>>();
    }

    /// <summary>
    /// Identifier of the model linked with current view model. Default value is null.
    /// If the form is from type 'Edit' - the identifier will be assigned from the Id value of the model.
    /// </summary>
    public string Identifier { get; set; }

    /// <summary>
    /// Inputs of form view.
    /// </summary>
    public List<EmPageFormInputModel> Inputs { get; set; }

    /// <summary>
    /// Pair that contains corresponding selectable custom data properties with registered <see cref="IFormViewSelectableCustomDataSource"/>.
    /// Key of the dictionary is the full assembly of the implementation of selectable custom data source.
    /// </summary>
    public IDictionary<string, IEnumerable<FormViewSelectableCustomDataItem>> ModelSelectableCustomDataMap { get; }

    /// <summary>
    /// List of all form errors that are not related to the input models.
    /// </summary>
    public List<string> NonMappedFormErrors { get; set; }

    /// <summary>
    /// Clears all errors related to this form view data.
    /// </summary>
    public void ClearErrors()
    {
        this.NonMappedFormErrors.Clear();
        foreach (var input in this.Inputs)
        {
            input.ValidationErrors.Clear();
        }
    }
}