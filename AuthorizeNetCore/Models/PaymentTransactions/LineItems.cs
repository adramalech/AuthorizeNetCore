using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class LineItems
    {
        [JsonPropertyName("lineItem")]
        public LineItem LineItem { get; set; }
    }
}