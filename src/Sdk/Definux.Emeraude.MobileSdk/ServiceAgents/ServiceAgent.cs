using Definux.Emeraude.MobileSdk.Configuration;
using Definux.Emeraude.MobileSdk.ServiceAgents.Http;
using Definux.Emeraude.MobileSdk.ServiceAgents.Settings;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Definux.Emeraude.MobileSdk.ServiceAgents
{
    public abstract class ServiceAgent
    {
        protected readonly IEmConfiguration configuration;
        protected readonly IHttpClientFactory clientFactory;
        protected readonly JsonSerializerSettings jsonSerializerSettings = new JsonSerializerSettings()
        {
            ContractResolver = new DefaultContractResolver
            {
                NamingStrategy = new CamelCaseNamingStrategy()
            },
            Formatting = Formatting.Indented
        };
        protected readonly HostSettings hostSettings;

        private const string DefaultMediaType = "application/json";

        public ServiceAgent(
            IEmConfiguration configuration,
            IHttpClientFactory clientFactory)
        {
            this.configuration = configuration;
            this.clientFactory = clientFactory;
            this.hostSettings = this.configuration.ToHostSettings();
        }

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
            catch (Exception) { }

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

        protected async Task<T> ParseResult<T>(HttpResponseMessage response)
        {
            if (!response.IsSuccessStatusCode)
            {
                await ParseJsonErrorAsync(response);
            }
            
            return JsonConvert.DeserializeObject<T>(await response.Content.ReadAsStringAsync(), this.jsonSerializerSettings);
        }

        protected async Task<TResponseData> GetAsync<TResponseData>(string requestUri)
        {
            try
            {
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpResponseMessage response = await httpClient.GetAsync(requestUri);
                    if (!response.IsSuccessStatusCode)
                    {
                        await ParseJsonErrorAsync(response);
                    }

                    string responseString = await response.Content.ReadAsStringAsync();
                    var result = JsonConvert.DeserializeObject<TResponseData>(responseString, this.jsonSerializerSettings);

                    return result;
                }
            }
            catch (Exception ex)
            {
                return default(TResponseData);
            }
        }

        protected async Task<TRequestData> PostAsync<TRequestData>(string requestUri, TRequestData data)
        {
            try
            {
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpContent contentPost = new StringContent(JsonConvert.SerializeObject(data, this.jsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PostAsync(requestUri, contentPost);
                    return await ParseResult<TRequestData>(response);
                }
            }
            catch (Exception)
            {
                return default(TRequestData);
            }
        }

        protected async Task<TReponseData> PostAsync<TRequestData, TReponseData>(string requestUri, TRequestData data)
        {
            try
            {
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    var aaa = JsonConvert.SerializeObject(data, this.jsonSerializerSettings);
                    HttpContent contentPost = new StringContent(JsonConvert.SerializeObject(data, this.jsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PostAsync(requestUri, contentPost);
                    return await ParseResult<TReponseData>(response);
                }
            }
            catch (Exception)
            {
                return default(TReponseData);
            }
        }

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

        protected async Task<TRequestData> PutAsync<TRequestData>(string requestUri, TRequestData data)
        {
            try
            {
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpContent contentPut = new StringContent(JsonConvert.SerializeObject(data, this.jsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                    return await ParseResult<TRequestData>(response);
                }
            }
            catch (Exception)
            {
                return default(TRequestData);
            }
        }

        protected async Task<TReponseData> PutAsync<TRequestData, TReponseData>(string requestUri, TRequestData data)
        {
            try
            {
                using (var httpClient = await this.clientFactory.CreateClientAsync(this.hostSettings))
                {
                    HttpContent contentPut = new StringContent(JsonConvert.SerializeObject(data, this.jsonSerializerSettings), Encoding.UTF8, DefaultMediaType);
                    HttpResponseMessage response = await httpClient.PutAsync(requestUri, contentPut);
                    return await ParseResult<TReponseData>(response);
                }
            }
            catch (Exception)
            {
                return default(TReponseData);
            }
        }

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
