using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Error
    {
        /// <summary>
        /// Error code returned.
        /// </summary>
        [JsonPropertyName("errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Text description of error.
        /// </summary>
        [JsonPropertyName("errorText")]
        public string ErrorText { get; set; }
    }
}
