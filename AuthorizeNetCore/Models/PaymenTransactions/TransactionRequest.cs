using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class TransactionRequest
    {
        [JsonProperty(PropertyName = "transactionType")]
        public string TransactionType { get; set; }

        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        [JsonProperty(PropertyName = "payment")]
        public Payment Payment { get; set; }

        [JsonProperty(PropertyName = "callId")]
        public string CallId { get; set; }

        [JsonProperty(PropertyName = "lineItems")]
        public LineItems LineItems { get; set; }

        [JsonProperty(PropertyName = "customerIP")]
        public string CustomerIP { get; set; }

        [JsonProperty(PropertyName = "userFields")]
        public UserFields UserFields { get; set; }
    }
}