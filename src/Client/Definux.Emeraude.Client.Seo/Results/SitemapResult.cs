using System;
using System.Collections.Generic;
using System.Xml.Serialization;

namespace Definux.Emeraude.Client.Seo.Results
{
    /// <summary>
    /// Implementation of application sitemap.
    /// </summary>
    [XmlType(TypeName = "urlset", Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9")]
    [XmlRoot(Namespace = "http://www.sitemaps.org/schemas/sitemap/0.9", IsNullable = false)]
    [Serializable]
    public class SitemapResult
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SitemapResult"/> class.
        /// </summary>
        public SitemapResult()
        {
            this.Urls = new List<SitemapUrl>();
        }

        /// <summary>
        /// Collection of sitemap pages URLs.
        /// </summary>
        [XmlElement("url")]
        public List<SitemapUrl> Urls { get; set; }

        /// <summary>
        /// Converts sitemap result to a sitemap XML format.
        /// </summary>
        /// <returns></returns>
        public string ToSerializedSitemapXml()
        {
            using (var stringWriter = new System.IO.StringWriter())
            {
                var serializer = new XmlSerializer(this.GetType());
                serializer.Serialize(stringWriter, this);
                return stringWriter.ToString();
            }
        }
    }
}
