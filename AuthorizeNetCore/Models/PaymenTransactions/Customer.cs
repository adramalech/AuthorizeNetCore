using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class Customer
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }
    }
}
