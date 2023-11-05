using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Order
    {
        /// <summary>
        /// Merchant-defined invoice number.
        /// </summary>
        [JsonPropertyName("invoiceNumber")]
        public string InvoiceNumber { get; set; }

        /// <summary>
        /// Description of the item purchased.
        /// </summary>
        [JsonPropertyName("description")]
        public string Description { get; set; }
    }
}
