using AuthorizeNetCore.Models;

namespace AuthorizeNetCore
{
    public class VisaCheckoutClient : AuthorizeNetClient
    {
        public VisaCheckoutClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3) : base(merchantAuthentication, isTestMode, retryCount)
        {
        }

    }
}
