using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class TransactionSettings
    {
        [JsonPropertyName("setting")]
        public Setting[] Setting { get; set; }
    }
}
