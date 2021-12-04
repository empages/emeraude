using System.Collections.Generic;

namespace Emeraude.Application.ClientBuilder.Requests.Commands.CreateKeyWithValues;

/// <summary>
/// New key with value request.
/// </summary>
public class NewKeyWithValuesRequest
{
    /// <summary>
    /// Translation key.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// Collection of all values for the requested key.
    /// </summary>
    public IEnumerable<NewKeyTranslationValue> Values { get; set; }
}