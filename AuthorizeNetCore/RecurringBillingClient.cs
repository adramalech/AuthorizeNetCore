using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.Authentication;

namespace AuthorizeNetCore
{
    public class RecurringBillingClient : AuthorizeNetClient
    {
        public RecurringBillingClient(MerchantAuthentication merchantAuthentication, bool isTestMode) : base(merchantAuthentication, isTestMode)
        {
        }

    }
}
