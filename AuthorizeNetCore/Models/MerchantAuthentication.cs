using System.ComponentModel.DataAnnotations;
using Newtonsoft.Json;

namespace AuthorizeNetCore.Models
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
        [MaxLength(20)]
        [Required]
        public string LoginId { get; set; }

        [JsonProperty(PropertyName = "transactionKey")]
        [MaxLength(16)]
        [Required]
        public string TransactionKey { get; set; }
    }
}
