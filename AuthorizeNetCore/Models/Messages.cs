using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class Messages
    {
        [JsonProperty(PropertyName = "resultCode")]
        public string ResultCode { get; set; }
        
        [JsonProperty(PropertyName = "message")]
        public Message[] Message { get; set; }
    }
}