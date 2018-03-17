using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class CreateTransactionRequest
    {
        /// <summary>
        /// Contains merchant authentication information.
        /// </summary>
        [JsonProperty(PropertyName = "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }

        /// <summary>
        /// Merchant-assigned reference ID for the request.
        /// </summary>
        [JsonProperty(PropertyName = "refId")]
        public string RefId { get; set; }

        /// <summary>
        /// This element is a container for transaction specific information.
        /// </summary>
        [JsonProperty(PropertyName = "transactionRequest")]
        public TransactionRequest TransactionRequest { get; set; }
    }
}