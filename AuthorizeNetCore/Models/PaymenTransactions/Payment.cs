using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class Payment
    {
        [JsonProperty(PropertyName = "creditCard")]
        public CreditCard CreditCard { get; set; }
    }
}