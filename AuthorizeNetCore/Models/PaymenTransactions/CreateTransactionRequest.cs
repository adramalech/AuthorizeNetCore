using Newtonsoft.Json;
using AuthorizeNetCore.Models.Authentication;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class CreateTransactionRequest
    {
        [JsonProperty(PropertyName = "merchantAuthentication")]
        public MerchantAuthentication MerchantAuthentication { get; set; }

        [JsonProperty(PropertyName = "refId")]
        public string RefId { get; set; }

        [JsonProperty(PropertyName = "transactionRequest")]
        public TransactionRequest TransactionRequest { get; set; }
    }
}