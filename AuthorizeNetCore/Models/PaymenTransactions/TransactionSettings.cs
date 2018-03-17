using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class TransactionSettings
    {
        [JsonProperty(PropertyName = "setting")]
        public Setting[] Setting { get; set; }
    }
}
