using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class LineItems
    {
        [JsonProperty(PropertyName = "lineItem")]
        public LineItem LineItem { get; set; }
    }
}