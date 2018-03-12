using System;
using System.Net.Http;
using System.Net.Http.Headers;
using AuthorizeNetCore.Models;
using AuthorizeNetCore.Utils;

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

            this.httpClient = new HttpClient(new RetryMessageHandler(retryCount))
            {
                BaseAddress = new Uri(this.baseUrl)
            };

            this.httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public string TestAuthentication()
        {
            throw new NotImplementedException();
        }
    }
}
