using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.Authentication
{
    public class AuthenticationTestResponse
    {
        [JsonProperty(PropertyName = "refId")]
        public string RefId { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public Messages Messages { get; set; }
    }
}