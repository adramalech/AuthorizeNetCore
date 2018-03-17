using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class CreditCard
    {
        /// <summary>
        /// The customer's creddit card number.
        /// </summary>
        [JsonProperty(PropertyName = "cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// The customer's credit card expiration date.  Use XML gMonthYear foramtting (YYYY-MM).
        /// </summary>
        [JsonProperty(PropertyName = "expirationDate")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// The customer's card code.  The three- or four-digit nubmer on the back of a credit card,
        /// or front if American Express.  
        /// 
        /// This field is required if the merchant would like to use the Card Code Verification (CCV) security feature.
        /// </summary>
        [JsonProperty(PropertyName = "cardCode")]
        public string CardCode { get; set; }
    }
}
