using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class Payment
    {
        [JsonProperty(PropertyName = "opaqueData")]
        public OpaqueData OpaqueData { get; set; }
    }
}