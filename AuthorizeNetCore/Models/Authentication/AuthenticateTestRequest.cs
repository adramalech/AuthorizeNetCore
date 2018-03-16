using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.Authentication
{
    public class AuthenticateTestRequest
    {
        [JsonProperty(PropertyName = "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }
    }
}
