using AuthorizeNetCore.Models;

namespace AuthorizeNetCore
{
    public class PayPalExpressCheckoutClient : AuthorizeNetClient
    {
        public PayPalExpressCheckoutClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3) : base(merchantAuthentication, isTestMode, retryCount)
        {
        }

    }
}
