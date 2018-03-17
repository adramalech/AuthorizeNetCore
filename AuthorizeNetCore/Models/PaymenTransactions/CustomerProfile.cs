using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class CustomerProfile
    {
        /// <summary>
        /// Indicates whether to create a customer profile.
        /// 
        /// If set to true, a customer profile and payment profile 
        /// will be generated from the customer and payment data.
        /// </summary>
        [JsonProperty(PropertyName = "createProfile")]
        public bool CreateProfile { get; set; }
    }
}
