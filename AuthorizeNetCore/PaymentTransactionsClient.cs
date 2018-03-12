using AuthorizeNetCore.Models;

namespace AuthorizeNetCore
{
    public class PaymentTransactionsClient : AuthorizeNetClient
    {
        public PaymentTransactionsClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3) : base(merchantAuthentication, isTestMode, retryCount)
        {
        }

    }
}
