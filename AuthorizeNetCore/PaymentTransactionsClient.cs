using System.Net.Http;
using System.Threading.Tasks;
using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.PaymentTransactions;
using Newtonsoft.Json;

namespace AuthorizeNetCore
{
    public class PaymentTransactionsClient : AuthorizeNetClient
    {
        public PaymentTransactionsClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3) : base(merchantAuthentication, isTestMode, retryCount)
        {
        }

        public async Task<CreateTransactionResponse> ChargeCreditCard(TransactionRequest transactionRequest, string refId = "")
        {
            var createTransactionRequest = new CreateTransactionRequest()
            {
                MerchantAuthentication = this.merchantAuthentication,
                RefId = refId,
                TransactionRequest = transactionRequest
            };
            
            var content = new StringContent(
                content: JsonConvert.SerializeObject(new { createTransactionRequest }),
                encoding: System.Text.Encoding.UTF8,
                mediaType: "application/json"
            );

            var response = await this.httpClient.PostAsync(this.baseUrl, content);

            var json = await response.Content.ReadAsStringAsync();

            return (!string.IsNullOrEmpty(json) && ValidateJson(json)) ? JsonConvert.DeserializeObject<CreateTransactionResponse>(json) : null;
        }

    }
}
