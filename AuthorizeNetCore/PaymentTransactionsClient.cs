using System.Net.Http;
using System.Threading.Tasks;
using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.PaymentTransactions;
using System.Text.Json;

namespace AuthorizeNetCore
{
    public class PaymentTransactionsClient : AuthorizeNetClient
    {
        public PaymentTransactionsClient(MerchantAuthentication merchantAuthentication, bool isTestMode) : base(merchantAuthentication, isTestMode)
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
                content: JsonSerializer.Serialize(new { createTransactionRequest }),
                encoding: System.Text.Encoding.UTF8,
                mediaType: "application/json"
            );

            var response = await this.httpClient.PostAsync(this.baseUrl, content);

            var json = await response.Content.ReadAsStringAsync();

            return (!string.IsNullOrEmpty(json)) ? JsonSerializer.Deserialize<CreateTransactionResponse>(json) : null;
        }

    }
}
