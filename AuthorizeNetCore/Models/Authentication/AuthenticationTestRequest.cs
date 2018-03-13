using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.Authentication
{
    public class AuthenticationTestRequest
    {
        [JsonProperty(PropertyName = "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }
    }
}