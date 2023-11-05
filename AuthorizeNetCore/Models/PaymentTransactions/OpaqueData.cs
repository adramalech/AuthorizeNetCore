using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class OpaqueData
    {
        [JsonPropertyName("dataDescriptor")]
        public string DataDescriptor
        {
            get { return "COMMON.ACCEPT.INAPP.PAYMENT"; }
        }

        [JsonPropertyName("dataValue")]
        public string NonceValue { get; set; }
    }
}
