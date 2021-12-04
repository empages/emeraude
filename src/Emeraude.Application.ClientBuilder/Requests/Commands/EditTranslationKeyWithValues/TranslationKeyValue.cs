namespace Emeraude.Application.ClientBuilder.Requests.Commands.EditTranslationKeyWithValues;

/// <summary>
/// Translation key value.
/// </summary>
public class TranslationKeyValue
{
    /// <summary>
    /// Id of the translation.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Value of the translation.
    /// </summary>
    public string Value { get; set; }
}