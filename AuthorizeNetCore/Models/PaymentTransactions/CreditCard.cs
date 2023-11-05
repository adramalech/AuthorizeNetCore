using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class CreditCard
    {
        /// <summary>
        /// The customer's creddit card number.
        /// </summary>
        [JsonPropertyName("cardNumber")]
        public string CardNumber { get; set; }

        /// <summary>
        /// The customer's credit card expiration date.  Use XML gMonthYear foramtting (YYYY-MM).
        /// </summary>
        [JsonPropertyName("expirationDate")]
        public string ExpirationDate { get; set; }

        /// <summary>
        /// The customer's card code.  The three- or four-digit nubmer on the back of a credit card,
        /// or front if American Express.  
        /// 
        /// This field is required if the merchant would like to use the Card Code Verification (CCV) security feature.
        /// </summary>
        [JsonPropertyName("cardCode")]
        public string CardCode { get; set; }
    }
}
