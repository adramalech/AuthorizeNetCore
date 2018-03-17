using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class CreateTransactionResponse
    {
        [JsonProperty(PropertyName = "transactionResponse")]
        public TransactionResponse TransactionResponse { get; set; }

        [JsonProperty(PropertyName = "refId")]
        public string RefId { get; set; }

        [JsonProperty(PropertyName = "messages")]
        public Messages Messages { get; set; }
    }
}