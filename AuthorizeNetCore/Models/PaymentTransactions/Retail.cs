using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Retail
    {
        /// <summary>
        /// The market type of the transaction.
        /// 
        /// Either "0" for e-commerce, "1" for MOTO, or "2" for retail.  Defaults to "2".
        /// </summary>
        [JsonPropertyName("marketType")]
        public string MarketType { get; set; }

        /// <summary>
        /// The type of device submitting the retail transaction.
        /// </summary>
        [JsonPropertyName("deviceType")]
        public string DeviceType { get; set; }
    }
}
