using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.Authentication;

namespace AuthorizeNetCore
{
    public class PayPalExpressCheckoutClient : AuthorizeNetClient
    {
        public PayPalExpressCheckoutClient(MerchantAuthentication merchantAuthentication, bool isTestMode) : base(merchantAuthentication, isTestMode)
        {
        }

    }
}
