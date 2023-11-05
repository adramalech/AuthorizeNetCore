using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.Authentication
{
    public class AuthenticateTestResponse
    {
        [JsonPropertyName("refId")]
        public string RefId { get; set; }

        [JsonPropertyName("messages")]
        public Messages Messages { get; set; }
    }
}
