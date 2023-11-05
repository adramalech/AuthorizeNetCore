using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class CreateTransactionRequest
    {
        /// <summary>
        /// Contains merchant authentication information.
        /// </summary>
        [JsonPropertyName("merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }

        /// <summary>
        /// Merchant-assigned reference ID for the request.
        /// </summary>
        [JsonPropertyName("refId")]
        public string RefId { get; set; }

        /// <summary>
        /// This element is a container for transaction specific information.
        /// </summary>
        [JsonPropertyName("transactionRequest")]
        public TransactionRequest TransactionRequest { get; set; }
    }
}