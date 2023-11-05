using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class CustomerContact
    {
        /// <summary>
        /// First name associated with customer's address.
        /// </summary>
        [JsonPropertyName("firstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///  Last name associated with customer's address.
        /// </summary>
        [JsonPropertyName("lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Company associatedd with customer's address.
        /// </summary>
        [JsonPropertyName("company")]
        public string Company { get; set; }

        /// <summary>
        /// Customer's address.
        /// </summary>
        [JsonPropertyName("address")]
        public string Address { get; set; }

        /// <summary>
        /// City of customer's address.
        /// </summary>
        [JsonPropertyName("city")]
        public string City { get; set; }

        /// <summary>
        /// State of customer's address.
        /// </summary>
        [JsonPropertyName("state")]
        public string State { get; set; }

        /// <summary>
        /// The postal code of customer's address.
        /// </summary>
        [JsonPropertyName("zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Country of customer's address.
        /// </summary>
        [JsonPropertyName("country")]
        public string Country { get; set; }
    }
}
