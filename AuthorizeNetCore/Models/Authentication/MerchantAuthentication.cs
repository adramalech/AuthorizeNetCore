using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.Authentication
{
    /// <summary>
    /// Contains merchant authentication information.
    /// 
    /// LoginID (name) - Merchant's unique API Login ID.
    /// 
    /// TransactionKey (transactionKey) - Merchant's unique Transaction Key.
    /// </summary>
    public class MerchantAuthentication
    {
        [JsonProperty(PropertyName = "name")]
        public string LoginId { get; set; }

        [JsonProperty(PropertyName = "transactionKey")]
        public string TransactionKey { get; set; }
    }
}
