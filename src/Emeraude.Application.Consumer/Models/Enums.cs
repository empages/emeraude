namespace Emeraude.Application.Consumer.Models
{
    /// <summary>
    /// Sitemap pages change frequency.
    /// </summary>
    public enum SeoChangeFrequencyTypes
    {
        /// <summary>
        /// Type 'Always'.
        /// </summary>
        Always = 1,

        /// <summary>
        /// Type 'Hourly'.
        /// </summary>
        Hourly = 2,

        /// <summary>
        /// Type 'Daily'.
        /// </summary>
        Daily = 3,

        /// <summary>
        /// Type 'Weekly'.
        /// </summary>
        Weekly = 4,

        /// <summary>
        /// Type 'Monthly'.
        /// </summary>
        Monthly = 5,

        /// <summary>
        /// Type 'Yearly'.
        /// </summary>
        Yearly = 6,

        /// <summary>
        /// Type 'Never'.
        /// </summary>
        Never = 7,
    }

    /// <summary>
    /// The most used meta tags.
    /// </summary>
    public enum MainMetaTags
    {
        /// <summary>
        /// Title.
        /// </summary>
        Title = 1,

        /// <summary>
        /// Description meta tag.
        /// </summary>
        Description = 2,

        /// <summary>
        /// Keywords meta tag.
        /// </summary>
        Keywords = 3,

        /// <summary>
        /// Image mata tag.
        /// </summary>
        Image = 4,

        /// <summary>
        /// Author meta tag.
        /// </summary>
        Author = 5,
    }
}
