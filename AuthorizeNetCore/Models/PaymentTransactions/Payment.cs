using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Payment
    {
        /// <summary>
        /// Contains human-readable information from the customer's card.
        /// Applies to Card Not Present transactions only.
        /// </summary>
        [JsonPropertyName("creditCard")]
        public CreditCard CreditCard { get; set; }
    }
}