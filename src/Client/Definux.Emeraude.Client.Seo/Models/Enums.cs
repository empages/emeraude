namespace Definux.Emeraude.Client.Seo.Models
{
    /// <summary>
    /// Sitemap pages change frequency.
    /// </summary>
    public enum SeoChangeFrequencyTypes
    {
        Always = 1,
        Hourly = 2,
        Daily = 3,
        Weekly = 4,
        Monthly = 5,
        Yearly = 6,
        Never = 7,
    }

    /// <summary>
    /// The most used meta tags.
    /// </summary>
    public enum MainMetaTags
    {
        Title = 1,
        Description = 2,
        Keywords = 3,
        Image = 4,
        Author = 5,
    }
}
