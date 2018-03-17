using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
{
    public class MerchantAuthentication
    {
        /// <summary>
        /// Merchant's unique API Login ID.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string LoginId { get; set; }

        /// <summary>
        /// Merchant's unique Transaction Key.
        /// </summary>
        [JsonProperty(PropertyName = "transactionKey")]
        public string TransactionKey { get; set; }
    }
}
