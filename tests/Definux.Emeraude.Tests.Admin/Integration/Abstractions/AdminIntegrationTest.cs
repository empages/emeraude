using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Tests.Abstractions;
using HtmlAgilityPack;
using Microsoft.Net.Http.Headers;

namespace Definux.Emeraude.Tests.Admin.Integration.Abstractions
{
    public class AdminIntegrationTest : IntegrationTest
    {
        public AdminIntegrationTest(EmeraudeWebApplicationFactory factory) 
            : base(factory)
        {
        }
        
        protected async Task AuthenticateAsync(
            string email = EmIdentityConstants.DefaultEmeraudeAdminEmail,
            string password = EmIdentityConstants.DefaultEmeraudeAdminPassword)
        {
            string adminLoginUrl = "/admin/login";
            var antiForgeryTokenMeta = await GetAntiForgeryTokenMetaFromPageAsync(adminLoginUrl);

            var postData = new Dictionary<string, string>
            {
                { "Email", email },
                { "Password", password },
                { antiForgeryTokenMeta.InputName, antiForgeryTokenMeta.InputValue }
            };

            var postRequest = new HttpRequestMessage(HttpMethod.Post, adminLoginUrl);
            postRequest.Headers.Add("Cookie", new CookieHeaderValue(antiForgeryTokenMeta.CookieName, antiForgeryTokenMeta.InputValue).ToString());
            postRequest.Content = new FormUrlEncodedContent(postData);
            var response = await this.HttpClient.SendAsync(postRequest);
            response.EnsureSuccessStatusCode();
        }
    }
}