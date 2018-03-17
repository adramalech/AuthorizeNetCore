using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.Authentication;
using AuthorizeNetCore.Models.PaymenTransactions;

namespace AuthorizeNetCore
{
    public class PaymentTransactionsClient : AuthorizeNetClient
    {
        public PaymentTransactionsClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3) : base(merchantAuthentication, isTestMode, retryCount)
        {
        }

    }
}
