using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Definux.Emeraude.Admin.Extensions;
using Definux.Emeraude.Application.Logger;
using Definux.Emeraude.Configuration.Authorization;
using Definux.Emeraude.Configuration.Extensions;
using Definux.Emeraude.Configuration.Options;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Definux.Emeraude.Admin.Services
{
    /// <summary>
    /// Abstract service agent that provides all methods for HTTP request to the admin Web API.
    /// </summary>
    public abstract class AdminServiceAgent
    {
        private const string DefaultMediaType = "application/json";

        /// <summary>
        /// Initializes a new instance of the <see cref="AdminServiceAgent"/> class.
        /// </summary>
        /// <param name="httpClientFactory"></param>
        /// <param name="httpContextAccessor"></param>
        /// <param name="optionsProvider"></param>
        /// <param name="logger"></param>
        public AdminServiceAgent(
            IHttpClientFactory httpClientFactory,
            IHttpContextAccessor httpContextAccessor,
            IEmOptionsProvider optionsProvider,
            IEmLogger logger)
        {
            this.HttpClientFactory = httpClientFactory;
            this.HttpContextAccessor = httpContextAccessor;
            this.Logger = logger;
            this.AdminOptions = optionsProvider.GetAdminOptions();
        }

        /// <inheritdoc cref="IHttpClientFactory"/>
        public IHttpClientFactory HttpClientFactory { get; }

        /// <inheritdoc cref="IHttpClientFactory"/>
        public IHttpContextAccessor HttpContextAccessor { get; }

        /// <inheritdoc cref="IEmLogger"/>
        public IEmLogger Logger { get; }

        /// <inheritdoc cref="EmAdminOptions"/>
        public EmAdminOptions AdminOptions { get; set; }

        /// <summary>
        /// Parse the result from the HTTP response.
        /// </summary>
        /// <typeparam name="T">Result model.</typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        protected async Task<T> ParseResultAsync<T>(HttpResponseMessage response)
        {
            return !response.IsSuccessStatusCode ? default : JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync(), this.AdminOptions.LocalJsonSerializerSettings);
        }

        /// <summary>
        /// Executes GET request to specified url from the target web API.
        /// </summary>
        /// <typeparam name="TResponseData">Result model.</typeparam>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        protected async Task<TResponseData> GetAsync<TResponseData>(string requestUri)
        {
            try
            {
                using var httpClient = this.CreateClient();
                HttpResponseMessage response = await httpClient.GetAsync(requestUri);
                return await this.ParseResultAsync<TResponseData>(response);
            }
            catch (Exception)
            {
                return default;
            }
        }

        /// <summary>
        /// Executes POST request to specified url with request model to the target web API that returns.
        /// </summary>
        /// <typeparam name="TRequestData">Request and result model.</typeparam>
        /// <param name="requestUri"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected async Task<TRequestData> PostAsync<TRequestData>(string requestUri, TRequestData data)
        {
            try
            {
                using var httpClient = this.CreateClient();
                HttpContent contentPost = new StringContent(JsonConvert.SerializeObject(data, this.AdminOptions.LocalJsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                HttpResponseMessage response = await httpClient.PostAsync(requestUri, contentPost);
                return await this.ParseResultAsync<TRequestData>(response);
            }
            catch (Exception)
            {
                return default;
            }
        }

        /// <summary>
        /// Executes POST request to specified url with request model to the target web API that returns.
        /// </summary>
        /// <typeparam name="TRequestData">Request model.</typeparam>
        /// <typeparam name="TReponseData">Result model.</typeparam>
        /// <param name="requestUri"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected async Task<TReponseData> PostAsync<TRequestData, TReponseData>(string requestUri, TRequestData data)
        {
            try
            {
                using var httpClient = this.CreateClient();
                HttpContent contentPost = new StringContent(JsonConvert.SerializeObject(data, this.AdminOptions.LocalJsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                HttpResponseMessage response = await httpClient.PostAsync(requestUri, contentPost);
                return await this.ParseResultAsync<TReponseData>(response);
            }
            catch (Exception)
            {
                return default;
            }
        }

        /// <summary>
        /// Execute POST request to specified url without a request model to the target web API that returns.
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        protected async Task<HttpStatusCode> PostWithoutResultAsync(string requestUri)
        {
            try
            {
                using var httpClient = this.CreateClient();
                HttpContent contentPost = new StringContent(string.Empty, Encoding.UTF8, DefaultMediaType);
                HttpResponseMessage response = await httpClient.PostAsync(requestUri, contentPost);
                return response.StatusCode;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }

        /// <summary>
        /// Executes PUT request to specified url with request model to the target web API that returns.
        /// </summary>
        /// <typeparam name="TRequestData">Request and result model.</typeparam>
        /// <param name="requestUri"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected async Task<TRequestData> PutAsync<TRequestData>(string requestUri, TRequestData data)
        {
            try
            {
                using var httpClient = this.CreateClient();
                HttpContent contentPut = new StringContent(JsonConvert.SerializeObject(data, this.AdminOptions.LocalJsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                return await this.ParseResultAsync<TRequestData>(response);
            }
            catch (Exception)
            {
                return default;
            }
        }

        /// <summary>
        /// Executes PUT request to specified url with request model to the target web API that returns.
        /// </summary>
        /// <typeparam name="TRequestData">Request model.</typeparam>
        /// <typeparam name="TReponseData">Result model.</typeparam>
        /// <param name="requestUri"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected async Task<TReponseData> PutAsync<TRequestData, TReponseData>(string requestUri, TRequestData data)
        {
            try
            {
                using var httpClient = this.CreateClient();
                HttpContent contentPut = new StringContent(JsonConvert.SerializeObject(data, this.AdminOptions.LocalJsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                return await this.ParseResultAsync<TReponseData>(response);
            }
            catch (Exception)
            {
                return default;
            }
        }

        /// <summary>
        /// Execute PUT request to specified url with a request model to the target web API that returns without a result.
        /// </summary>
        /// <typeparam name="TRequestData">Request model.</typeparam>
        /// <param name="requestUri"></param>
        /// <param name="data"></param>
        /// <returns></returns>
        protected async Task<HttpStatusCode> PutWithoutResultAsync<TRequestData>(string requestUri, TRequestData data)
        {
            try
            {
                using var httpClient = this.CreateClient();
                HttpContent contentPut = new StringContent(JsonConvert.SerializeObject(data, this.AdminOptions.LocalJsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                return response.StatusCode;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }

        /// <summary>
        /// Execute PUT request to specified url without a request model to the target web API that returns without a result.
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        protected async Task<HttpStatusCode> PutWithoutResultAsync(string requestUri)
        {
            try
            {
                using var httpClient = this.CreateClient();
                HttpContent contentPut = new StringContent(string.Empty, Encoding.UTF8, DefaultMediaType);
                HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                return response.StatusCode;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }

        /// <summary>
        /// Execute DELETE request to specified url to the target web API that returns without a result.
        /// </summary>
        /// <param name="requestUri"></param>
        /// <returns></returns>
        protected async Task<HttpStatusCode> DeleteWithoutResultAsync(string requestUri)
        {
            try
            {
                using var httpClient = this.CreateClient();
                HttpResponseMessage response = await httpClient.DeleteAsync(requestUri);
                return response.StatusCode;
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }

        /// <summary>
        /// Creates HTTP client.
        /// </summary>
        /// <returns></returns>
        protected HttpClient CreateClient()
        {
            var httpClient = this.HttpClientFactory.CreateClient(DefaultNames.HttpClientName);
            var httpContext = this.HttpContextAccessor.HttpContext;
            var adminCookie = $"{AuthenticationDefaults.AdminCookieName}={httpContext?.Request.Cookies[AuthenticationDefaults.AdminCookieName]}";
            httpClient.DefaultRequestHeaders.Add("Cookie", adminCookie);

            return httpClient;
        }
    }
}