using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Error
    {
        /// <summary>
        /// Error code returned.
        /// </summary>
        [JsonProperty(PropertyName = "errorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Text description of error.
        /// </summary>
        [JsonProperty(PropertyName = "errorText")]
        public string ErrorText { get; set; }
    }
}
