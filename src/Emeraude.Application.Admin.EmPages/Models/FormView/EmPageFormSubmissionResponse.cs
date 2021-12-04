using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace Emeraude.Application.Admin.EmPages.Models.FormView;

/// <summary>
/// Response of form view data submission.
/// </summary>
public class EmPageFormSubmissionResponse
{
    /// <summary>
    /// Initializes a new instance of the <see cref="EmPageFormSubmissionResponse"/> class.
    /// </summary>
    public EmPageFormSubmissionResponse()
    {
        this.ValidationErrors = new Dictionary<string, string[]>();
    }

    /// <summary>
    /// Id of the mutated model.
    /// </summary>
    public string MutatedModelId { get; set; }

    /// <summary>
    /// Returns boolean that indicates whether the response is succeeded or not
    /// based on the <see cref="MutatedModelId"/>. To be a successful response
    /// the <see cref="MutatedModelId"/> has to be different than (0 || Guid.Empty || string.Empty || null).
    /// </summary>
    public bool Succeeded
    {
        get
        {
            bool isEmptyOrNull = string.IsNullOrEmpty(this.MutatedModelId);
            bool isZero = this.MutatedModelId == "0";
            bool isGuidEmpty = this.MutatedModelId == Guid.Empty.ToString();

            return !isEmptyOrNull && !isZero && !isGuidEmpty;
        }
    }

    /// <summary>
    /// Dictionary with all errors thrown during the operation execution.
    /// </summary>
    public IDictionary<string, string[]> ValidationErrors { get; }

    /// <summary>
    /// Error occured during operation that is not related to the model itself.
    /// </summary>
    public string OperationError { get; set; }
}