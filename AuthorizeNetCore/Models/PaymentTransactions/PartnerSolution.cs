﻿using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class PartnerSolution
    {
        /// <summary>
        /// The unique Solution ID which you generate and associate with your solution through the Partner Interface.
        /// </summary>
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        /// <summary>
        /// The name is generated by the solution provider and provided to Authorize.Net.
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }
    }
}
