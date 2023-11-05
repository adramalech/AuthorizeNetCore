using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Errors
    {
        /// <summary>
        /// Contains detailed informatin about any errors returned.
        /// </summary>
        [JsonPropertyName("error")]
        public Error[] Error { get; set; }
    }
}
