using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class Errors
    {
        /// <summary>
        /// Contains detailed informatin about any errors returned.
        /// </summary>
        [JsonProperty(PropertyName = "error")]
        public Error[] Error { get; set; }
    }
}
