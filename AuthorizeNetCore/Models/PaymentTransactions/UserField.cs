using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class UserField
    {
        /// <summary>
        /// Name of the user-defined field.
        /// </summary>
        [JsonPropertyName("name")]
        public string Name { get; set; }

        /// <summary>
        /// Value of the user-defined field.
        /// </summary>
        [JsonPropertyName("value")]
        public string Value { get; set; }
    }
}