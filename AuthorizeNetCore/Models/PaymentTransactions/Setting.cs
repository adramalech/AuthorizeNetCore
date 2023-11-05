using System.Text.Json.Serialization;

namespace AuthorizeNetCore.Models.PaymentTransactions
{
    public class Setting
    {
        /// <summary>
        /// Name of a specific setting to be modified for this transaction.
        /// </summary>
        [JsonPropertyName("settingName")]
        public string SettingName { get; set; }

        /// <summary>
        /// Indicates whether the specified setting is enabled or disabled.
        /// </summary>
        [JsonPropertyName("settingValue")]
        public string SettingValue { get; set; }
    }
}
