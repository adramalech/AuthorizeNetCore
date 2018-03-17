using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Surcharge
    {
        /// <summary>
        /// Amount of the surcharge.
        /// </summary>
        [JsonProperty(PropertyName = "amount")]
        public decimal Amount { get; set; }

        /// <summary>
        /// Describes the reason or details for the surcharge.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
