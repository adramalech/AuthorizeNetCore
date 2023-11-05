using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class TransactionResponse
    {
        [JsonPropertyName("responseCode")]
        public string ResponseCode { get; set; }

        [JsonPropertyName("authCode")]
        public string AuthCode { get; set; }

        [JsonPropertyName("avsResultCode")]
        public string AVSResultCode { get; set; }

        [JsonPropertyName("cvvResultCode")]
        public string CVVResultCode { get; set; }

        [JsonPropertyName("cavvResultCode")]
        public string CAVVResultCode { get; set; }

        [JsonPropertyName("transId")]
        public string TransId { get; set; }

        [JsonPropertyName("refTransID")]
        public string RefTransID { get; set; }

        [JsonPropertyName("transHash")]
        public string TransHash { get; set; }

        [JsonPropertyName("accountNumber")]
        public string AccountNumber { get; set; }

        [JsonPropertyName("accountType")]
        public string AccountType { get; set; }

        [JsonPropertyName("messages")]
        public TransactionResponseMessages[] Messages { get; set; }

        /// <summary>
        /// Contains one or more errors.
        /// </summary>
        [JsonPropertyName("errors")]
        public Errors Errors { get; set; }

        [JsonPropertyName("userFields")]
        public UserField[] UserFields { get; set; }
    }
}