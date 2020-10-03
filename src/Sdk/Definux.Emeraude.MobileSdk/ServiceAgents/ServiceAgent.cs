using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.ServiceAgents.Http;
using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    /// <summary>
    /// Abstract service agent that provides all methods for HTTP request to the web API.
    /// </summary>
    public abstract class ServiceAgent
    {
        private const string DefaultMediaType = "application/json";

        private readonly IEmConfiguration configuration;
        private readonly IHttpClientFactory clientFactory;
        private readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings()
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy(),
            },
            Formatting = Formatting.Indented,
        };

        private readonly HostSettings hostSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="ServiceAgent"/> class.
        /// </summary>
        /// <param name="configuration"></param>
        /// <param name="clientFactory"></param>
        public ServiceAgent(
            IEmConfiguration configuration,
            IHttpClientFactory clientFactory)
        {
            this.configuration = configuration;
            this.clientFactory = clientFactory;
            this.hostSettings = this.configuration.ToHostSettings();
        }

        /// <summary>
        /// Parse the error(in JSON format) from HTTP response.
        /// </summary>
        /// <param name="response"></param>
        /// <returns></returns>
        protected async Task ParseJsonErrorAsync(HttpResponseMessage response)
        {
            var errorJson = await response.Content.ReadAsStringAsync();
            ServiceAgentRequestError errorResponse = null;

            try
            {
                if (errorJson.Length > 0)
                {
                    errorResponse = JsonConvert.DeserializeObject<ServiceAgentRequestError>(errorJson, this.jsonSerializerSettings);

                    if (errorResponse?.ExtraParameters == null)
                    {
                        errorResponse.ExtraParameters = new Dictionary<string, IEnumerable<string>>();
                    }
                }
            }
            catch (Exception)
            {
            }

            var errorTitle = errorResponse?.Title;
            switch (response.StatusCode)
            {
                case HttpStatusCode.NotFound:
                    throw new ArgumentException(message: errorTitle ?? "Not found");

                case HttpStatusCode.BadRequest:
                    throw new ArgumentException(message: errorTitle ?? "Bad request");

                case HttpStatusCode.Unauthorized:
                    throw new ArgumentException(message: errorTitle ?? "Access denied");

                case HttpStatusCode.Forbidden:
                    throw new ArgumentException(message: errorTitle ?? "Forbidden");

                default:
                    throw new ArgumentException(message: errorTitle);
            }
        }

        /// <summary>
        /// Parse the result from the HTTP response.
        /// </summary>
        /// <typeparam name="T">Result model.</typeparam>
        /// <param name="response"></param>
        /// <returns></returns>
        protected async Task<T> ParseResult<T>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                await this.ParseJsonErrorAsync(response);
            }

            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync(), this.jsonSerializerSettings);
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
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpResponseMessage response = await httpClient.GetAsync(requestUri);
                    if (!response.IsSuccessStatusCode)
                    {
                        await this.ParseJsonErrorAsync(response);
                    }

                    string responseString = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<TResponseData>(responseString, this.jsonSerializerSettings);

                    return result;
                }
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
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpContent contentPost = new StringContent(JsonConvert.SerializeObject(data, this.jsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PostAsync(requestUri, contentPost);
                    return await this.ParseResult<TRequestData>(response);
                }
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
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    var aaa = JsonConvert.SerializeObject(data, this.jsonSerializerSettings);
                    HttpContent contentPost = new StringContent(JsonConvert.SerializeObject(data, this.jsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PostAsync(requestUri, contentPost);
                    return await this.ParseResult<TReponseData>(response);
                }
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
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpContent contentPost = new StringContent(string.Empty, Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PostAsync(requestUri, contentPost);
                    return response.StatusCode;
                }
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
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpContent contentPut = new StringContent(JsonConvert.SerializeObject(data, this.jsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                    return await this.ParseResult<TRequestData>(response);
                }
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
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpContent contentPut = new StringContent(JsonConvert.SerializeObject(data, this.jsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                    return await this.ParseResult<TReponseData>(response);
                }
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
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpContent contentPut = new StringContent(JsonConvert.SerializeObject(data, this.jsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                    return response.StatusCode;
                }
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
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpContent contentPut = new StringContent(string.Empty, Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                    return response.StatusCode;
                }
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
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpResponseMessage response = await httpClient.DeleteAsync(requestUri);
                    return response.StatusCode;
                }
            }
            catch (Exception)
            {
                return HttpStatusCode.BadRequest;
            }
        }
    }
}
