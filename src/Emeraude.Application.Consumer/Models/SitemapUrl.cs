using System.Xml.Serialization;

namespace Emeraude.Application.Consumer.Models
{
    /// <summary>
    /// Sitemap page URL.
    /// </summary>
    public class SitemapUrl
    {
        /// <summary>
        /// Locaiton (URL) of the sitemap page.
        /// </summary>
        [XmlElement("loc")]
        public string Location { get; set; }

        /// <summary>
        /// Date of last modification of the page.
        /// </summary>
        [XmlElement("lastmod")]
        public string LastModification { get; set; }

        /// <summary>
        /// Frequency of changing for current page.
        /// </summary>
        [XmlElement("changefreq")]
        public string ChangeFrequency { get; set; }

        /// <summary>
        /// Priority of the page for search engines.
        /// </summary>
        [XmlElement("priority")]
        public string Priority { get; set; }
    }
}
