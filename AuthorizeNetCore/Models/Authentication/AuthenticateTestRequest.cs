
using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.Authentication
{
    public class AuthenticateTestRequest
    {
        [JsonPropertyName( "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }
    }
}
