﻿using System;
using System.Net.Http;
using System.Threading.Tasks;
using System.Net.Http.Headers;
using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.Authentication;
using AuthorizeNetCore.Utils;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AuthorizeNetCore
{
    public class AuthorizeNetClient
    {
        //constants.
        private const string _sandboxApiEndpoint = @"https://apitest.authorize.net/xml/v1/request.api";
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

        public async Task<AuthenticateTestResponse> TestAuthentication()
        {
            var authenticateTestRequest = new AuthenticateTestRequest()
            {
                MerchantAuthentication = merchantAuthentication
            };

            var content = new StringContent(
                content: JsonConvert.SerializeObject(new { authenticateTestRequest }), 
                encoding: System.Text.Encoding.UTF8, 
                mediaType: "application/json"
            );

            var response = await this.httpClient.PostAsync(this.baseUrl, content);

            var json = await response.Content.ReadAsStringAsync();

            return (!string.IsNullOrEmpty(json) && ValidateJson(json)) ? JsonConvert.DeserializeObject<AuthenticateTestResponse>(json) : null;
        }

        protected bool ValidateJson(string json) {
            try {
                var jsonParsedResult = JToken.Parse(json);
                return true;
            }
            catch (Exception ex) {
                return false;
            }
        }
    }
}
