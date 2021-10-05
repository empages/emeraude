using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.EmPages;
using Definux.Emeraude.Admin.EmPages.Schema;
using Definux.Emeraude.Application.Persistence;
using Definux.Emeraude.Identity.Entities;
using Definux.Utilities.Extensions;
using Microsoft.EntityFrameworkCore;

namespace Definux.Emeraude.Admin.ValuePipes
{
    /// <summary>
    /// Transform user Id to following format 'Sample User (sample.user@example.com)'.
    /// </summary>
    public class UserDetailsValuePipe : IValuePipe
    {
        private readonly IEmContextFactory contextFactory;
        private Dictionary<Guid, string> userDetailsPair;

        /// <summary>
        /// Initializes a new instance of the <see cref="UserDetailsValuePipe"/> class.
        /// </summary>
        /// <param name="contextFactory"></param>
        public UserDetailsValuePipe(IEmContextFactory contextFactory)
        {
            this.contextFactory = contextFactory;
            this.userDetailsPair = new Dictionary<Guid, string>();
        }

        /// <inheritdoc />
        public async Task PrepareAsync(IEnumerable<object> targetObjects, string[] parameters)
        {
            var targetUserIds = targetObjects.Select(x => (Guid)x);
            await using var context = await this.contextFactory.CreateDbContextAsync();
            this.userDetailsPair = await context
                .Set<User>()
                .Where(x => targetUserIds.Contains(x.Id))
                .ToDictionaryAsync(k => k.Id, v => $"{v.Name} ({v.Email})");
        }

        /// <inheritdoc />
        public async Task<object> ConvertAsync(object value)
        {
            string result = string.Empty;
            var userId = value.GetGuidValueOrDefault();
            if (userId != Guid.Empty && this.userDetailsPair.ContainsKey(userId))
            {
                result = this.userDetailsPair[userId];
            }

            return await Task.FromResult(result);
        }
    }
}