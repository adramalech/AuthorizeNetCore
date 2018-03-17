using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class CreateTransactionResponse
    {
        [JsonProperty(PropertyName = "transactionResponse")]
        public TransactionResponse TransactionResponse { get; set; }

        /// <summary>
        /// Merchant-assigned referene ID for the request.
        /// </summary>
        [JsonProperty(PropertyName = "refId")]
        public string RefId { get; set; }

        /// <summary>
        /// Contains one or more messages.
        /// </summary>
        [JsonProperty(PropertyName = "messages")]
        public Messages Messages { get; set; }
    }
}