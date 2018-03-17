using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class OpaqueData
    {
        [JsonProperty(PropertyName = "dataDescriptor")]
        public string DataDescriptor { get; set; }

        [JsonProperty(PropertyName = "dataValue")]
        public string DataValue { get; set; }

        [JsonProperty(PropertyName = "dataKey")]
        public string DataKey { get; set; }
    }
}