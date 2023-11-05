using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class CustomerProfile
    {
        /// <summary>
        /// Indicates whether to create a customer profile.
        /// 
        /// If set to true, a customer profile and payment profile 
        /// will be generated from the customer and payment data.
        /// </summary>
        [JsonPropertyName("createProfile")]
        public bool CreateProfile { get; set; }
    }
}
