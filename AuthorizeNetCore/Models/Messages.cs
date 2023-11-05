using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models
{
    public class Messages
    {
        [JsonPropertyName("resultCode")]
        public string ResultCode { get; set; }
        
        [JsonPropertyName("message")]
        public Message[] Message { get; set; }
    }
}