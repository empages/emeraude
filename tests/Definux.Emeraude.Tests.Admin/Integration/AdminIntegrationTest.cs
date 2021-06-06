﻿using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;
using Definux.Emeraude.Configuration.Options;
using Definux.Emeraude.Tests.Base;
using Microsoft.AspNetCore.Mvc.Testing;
using Microsoft.Net.Http.Headers;
using Xunit;

namespace Definux.Emeraude.Tests.Admin.Integration
{
    public class AdminIntegrationTest : IClassFixture<EmeraudeWebApplicationFactory>
    {
        private readonly EmeraudeWebApplicationFactory factory;
        
        public AdminIntegrationTest(EmeraudeWebApplicationFactory factory)
        {
            this.factory = factory;
            this.HttpClient = this.factory.CreateClient(new WebApplicationFactoryClientOptions
            {
                HandleCookies = true,
                AllowAutoRedirect = true
            });
        }
        
        public HttpClient HttpClient { get; }

        
        
        protected async Task AuthenticateAsync(
            string email = EmIdentityConstants.DefaultEmeraudeAdminEmail,
            string password = EmIdentityConstants.DefaultEmeraudeAdminPassword)
        {
            string adminLoginUrl = "/admin/login";
            var antiForgeryTokenMeta = await Base.Utilities.GetAntiForgeryTokenMetaFromPageAsync(adminLoginUrl, this.HttpClient);

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