using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class Order
    {
        /// <summary>
        /// Merchant-defined invoice number.
        /// </summary>
        [JsonProperty(PropertyName = "invoiceNumber")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Description of the item purchased.
        /// </summary>
        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }
    }
}
