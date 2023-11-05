using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class UserFields
    {
        /// <summary>
        /// Indivudal user-defined fields. 
        /// </summary>
        [JsonPropertyName("userField")]
        public UserField[] UserField { get; set; }
    }
}