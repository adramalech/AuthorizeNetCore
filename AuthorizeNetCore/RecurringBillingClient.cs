using AuthorizeNetCore.Models;

namespace AuthorizeNetCore
{
    public class RecurringBillingClient : AuthorizeNetClient
    {
        public RecurringBillingClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3) : base(merchantAuthentication, isTestMode, retryCount)
        {
        }

    }
}
