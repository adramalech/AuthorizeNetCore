using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class Retail
    {
        /// <summary>
        /// The market type of the transaction.
        /// 
        /// Either "0" for e-commerce, "1" for MOTO, or "2" for retail.  Defaults to "2".
        /// </summary>
        [JsonProperty(PropertyName = "marketType")]
        public string MarketType { get; set; }

        /// <summary>
        /// The type of device submitting the retail transaction.
        /// </summary>
        [JsonProperty(PropertyName = "deviceType")]
        public string DeviceType { get; set; }
    }
}
