using Newtonsoft.Json;

namespace AuthorizeNetCore.Models.PaymenTransactions
{
    public class Setting
    {
        /// <summary>
        /// Name of a specific setting to be modified for this transaction.
        /// </summary>
        [JsonProperty(PropertyName = "settingName")]
        public string SettingName { get; set; }

        /// <summary>
        /// Indicates whether the specified setting is enabled or disabled.
        /// </summary>
        [JsonProperty(PropertyName = "settingValue")]
        public string SettingValue { get; set; }
    }
}
