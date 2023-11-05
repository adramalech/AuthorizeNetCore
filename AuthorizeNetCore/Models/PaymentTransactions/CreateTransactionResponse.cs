using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class CreateTransactionResponse
    {
        [JsonPropertyName("transactionResponse")]
        public TransactionResponse TransactionResponse { get; set; }

        /// <summary>
        /// Merchant-assigned referene ID for the request.
        /// </summary>
        [JsonPropertyName("refId")]
        public string RefId { get; set; }

        /// <summary>
        /// Contains one or more messages.
        /// </summary>
        [JsonPropertyName("messages")]
        public Messages Messages { get; set; }
    }
}