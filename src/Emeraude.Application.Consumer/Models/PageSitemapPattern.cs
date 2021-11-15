using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Emeraude.Infrastructure.Localization.Services;

namespace Emeraude.Application.Consumer.Models
{
    /// <summary>
    /// Definition of sitemap page structure. Its purpose is to defines the pattern of single/multiple page/s of the sitemap.
    /// </summary>
    public class PageSitemapPattern
    {
        private string baseUrl;

        /// <summary>
        /// Initializes a new instance of the <see cref="PageSitemapPattern"/> class.
        /// </summary>
        /// <param name="template"></param>
        /// <param name="languageStore"></param>
        public PageSitemapPattern(string template, ILanguageStore languageStore)
        {
            this.Patterns.Add(template);
            this.Patterns.AddRange(languageStore
                .GetLanguages()
                .Where(x => !x.IsDefault)
                .Select(x => $"/{x.Code}{template}")
                .ToList());
        }

        /// <summary>
        /// Flag indicates that the pattern will be applied into a single page or not.
        /// </summary>
        public bool SinglePage { get; set; } = true;

        /// <summary>
        /// Domain name of the current sitemap page. This property is with priority than base URL.
        /// </summary>
        public string Domain { get; set; }

        /// <summary>
        /// Collection of all page patterns which will be applied for the current object URL generation.
        /// </summary>
        public List<string> Patterns { get; set; } = new ();

        /// <summary>
        /// Priority of the sitemap page for search engines.
        /// </summary>
        public float Priority { get; set; } = 0.5f;

        /// <inheritdoc cref="SeoChangeFrequencyTypes"/>
        public SeoChangeFrequencyTypes ChangeFrequency { get; set; } = SeoChangeFrequencyTypes.Always;

        /// <summary>
        /// Last modification of the url.
        /// </summary>
        public List<DateTime> LastModificationDates { get; set; } = new ();

        /// <summary>
        /// Function that contains logic for accessing data from any source for generating the sitemap.
        /// </summary>
        public Func<Task<IEnumerable<string[]>>> DataAccessor { get; set; }

        /// <summary>
        /// Set the base URL of the page.
        /// </summary>
        /// <param name="baseUrl"></param>
        public void SetBaseUrl(string baseUrl)
        {
            this.baseUrl = baseUrl;
        }

        /// <summary>
        /// Builds the collection of sitemap URLs that must be added to the <see cref="SitemapResult"/>.
        /// </summary>
        /// <returns></returns>
        public async Task<List<SitemapUrl>> BuildPatternUrlsAsync()
        {
            var result = new List<SitemapUrl>();
            string domain = string.IsNullOrWhiteSpace(this.Domain) ? this.baseUrl : this.Domain;
            IEnumerable<string[]> data = new List<string[]>();
            if (this.DataAccessor != null)
            {
                data = await this.DataAccessor?.Invoke();
            }

            foreach (var pattern in this.Patterns)
            {
                if (!this.SinglePage)
                {
                    var dataIndex = 0;
                    foreach (var dataItemArgs in data)
                    {
                        string route = string.Format(pattern, dataItemArgs);
                        result.Add(new SitemapUrl
                        {
                            Location = $"{domain}{route}",
                            Priority = this.Priority.ToString(CultureInfo.InvariantCulture),
                            ChangeFrequency = this.ChangeFrequency.ToString(),
                            LastModification = this.GetLastModificationDate(dataIndex),
                        });

                        dataIndex++;
                    }
                }
                else
                {
                    result.Add(new SitemapUrl
                    {
                        Location = $"{domain}{pattern}",
                        Priority = this.Priority.ToString(CultureInfo.InvariantCulture),
                        ChangeFrequency = this.ChangeFrequency.ToString(),
                        LastModification = this.GetLastModificationDate(0),
                    });
                }
            }

            return result;
        }

        private string GetLastModificationDate(int index)
        {
            var date = string.Empty;
            if (this.LastModificationDates.Count > index)
            {
                date = this.LastModificationDates
                    .ElementAt(index)
                    .ToString("o");
            }

            return date;
        }
    }
}
