using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models
{
    public class MerchantAuthentication
    {
        /// <summary>
        /// Merchant's unique API Login ID.
        /// </summary>
        [JsonPropertyName("name")]
        public string LoginId { get; set; }

        /// <summary>
        /// Merchant's unique Transaction Key.
        /// </summary>
        [JsonPropertyName("transactionKey")]
        public string TransactionKey { get; set; }
    }
}
