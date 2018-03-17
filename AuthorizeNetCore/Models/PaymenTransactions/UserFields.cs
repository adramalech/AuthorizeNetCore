using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
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