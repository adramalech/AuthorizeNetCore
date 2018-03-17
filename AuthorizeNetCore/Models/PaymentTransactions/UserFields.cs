using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class UserFields
    {
        /// <summary>
        /// Indivudal user-defined fields. 
        /// </summary>
        [JsonProperty(PropertyName = "userField")]
        public UserField[] UserField { get; set; }
    }
}