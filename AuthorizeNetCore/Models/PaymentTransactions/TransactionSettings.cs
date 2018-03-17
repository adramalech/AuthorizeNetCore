using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class TransactionSettings
    {
        [JsonProperty(PropertyName = "setting")]
        public Setting[] Setting { get; set; }
    }
}
