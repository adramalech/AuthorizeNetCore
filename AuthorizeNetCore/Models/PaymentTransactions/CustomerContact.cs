using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class CustomerContact
    {
        /// <summary>
        /// First name associated with customer's address.
        /// </summary>
        [JsonProperty(PropertyName = "firstName")]
        public string FirstName { get; set; }

        /// <summary>
        ///  Last name associated with customer's address.
        /// </summary>
        [JsonProperty(PropertyName = "lastName")]
        public string LastName { get; set; }

        /// <summary>
        /// Company associatedd with customer's address.
        /// </summary>
        [JsonProperty(PropertyName = "company")]
        public string Company { get; set; }

        /// <summary>
        /// Customer's address.
        /// </summary>
        [JsonProperty(PropertyName = "address")]
        public string Address { get; set; }

        /// <summary>
        /// City of customer's address.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// State of customer's address.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        /// <summary>
        /// The postal code of customer's address.
        /// </summary>
        [JsonProperty(PropertyName = "zip")]
        public string Zip { get; set; }

        /// <summary>
        /// Country of customer's address.
        /// </summary>
        [JsonProperty(PropertyName = "country")]
        public string Country { get; set; }
    }
}
