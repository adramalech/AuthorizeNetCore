using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models
{
    public class Message
    {
        [JsonPropertyName("code")]
        public string Code { get; set; }

        [JsonPropertyName("text")]
        public string Text { get; set; }
    }
}