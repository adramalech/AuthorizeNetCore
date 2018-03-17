using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class LineItems
    {
        [JsonProperty(PropertyName = "lineItem")]
        public LineItem LineItem { get; set; }
    }
}