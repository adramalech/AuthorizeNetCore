using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using AuthorizeNetCore.Models;
using AuthorizeNetCore.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AuthorizeNetCore
{
    public class AuthorizeNetClient
    {
        //constants.
        private const string _sandboxApiEndpoint = @"https://apitest.authroize.net/xml/v1/request.api";
        private const string _productionApiEndpoint = @"https://api.authorize.net/xml/v1/request.api";

        protected readonly MerchantAuthentication merchantAuthentication;
        protected readonly string baseUrl;
        protected HttpClient httpClient;

        public AuthorizeNetClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3)
        {
            this.merchantAuthentication = merchantAuthentication;

            this.baseUrl = (isTestMode) ? _sandboxApiEndpoint : _productionApiEndpoint;

            this.httpClient = new HttpClient(new RetryMessageHandler(retryCount));

            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<string> TestAuthentication()
        {
            var content = new StringContent(content: JsonConvert.SerializeObject(merchantAuthentication), encoding: System.Text.Encoding.UTF8, mediaType: "application/json");

            var response = await this.httpClient.PostAsync(this.baseUrl, content);

            var json = await response.Content.ReadAsStringAsync();

            //todo uncomment when models are correctly added.
            //return (!string.IsNullOrEmpty(json) && ValidateJson(json)) ? JsonConvert.DeserializeObject<>(json) : null;

            return json;
        }

        protected bool ValidateJson(string json) {
            try {
                JToken.Parse(json);
                return true;
            }
            catch (Exception) {
                return false;
            }
        }
    }
}
