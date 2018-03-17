using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class UserFields
    {
        [JsonProperty(PropertyName = "userField")]
        public UserField[] UserField { get; set; }
    }
}