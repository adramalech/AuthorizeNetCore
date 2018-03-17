using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class Payment
    {
        /// <summary>
        /// Contains human-readable information from the customer's card.
        /// Applies to Card Not Present transactions only.
        /// </summary>
        [JsonProperty(PropertyName = "creditCard")]
        public CreditCard CreditCard { get; set; }
    }
}