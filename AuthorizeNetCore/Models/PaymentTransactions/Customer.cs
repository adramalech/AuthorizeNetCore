using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Customer
    {
        /// <summary>
        /// Type of customer.  Either "individual" or "business".
        /// </summary>
        [JsonProperty(PropertyName = "type")]
        public string Type { get; set; }

        /// <summary>
        /// The unique customer ID used to represent the customer associated with the transaction.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The customer's valid email address. 
        /// 
        /// Required only when using a European payment procesesor.
        /// </summary>
        [JsonProperty(PropertyName = "email")]
        public string Email { get; set; }
    }
}
