using System.Collections.Generic;

namespace Emeraude.Infrastructure.Localization.Persistence.Entities;

/// <summary>
/// Key of the static content.
/// </summary>
public class ContentKey
{
    /// <summary>
    /// Initializes a new instance of the <see cref="ContentKey"/> class.
    /// </summary>
    public ContentKey()
    {
        this.StaticContentList = new HashSet<StaticContent>();
    }

    /// <summary>
    /// Id of the content key.
    /// </summary>
    public int Id { get; set; }

    /// <summary>
    /// Key of the content key.
    /// </summary>
    public string Key { get; set; }

    /// <summary>
    /// List of all static content items which are using the key.
    /// </summary>
    public ICollection<StaticContent> StaticContentList { get; set; }
}