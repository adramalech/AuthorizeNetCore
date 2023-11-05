using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Surcharge
    {
        /// <summary>
        /// Amount of the surcharge.
        /// </summary>
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Describes the reason or details for the surcharge.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
