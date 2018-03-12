using AuthorizeNetCore.Models;

namespace AuthorizeNetCore
{
    public class CustomerProfileClient : AuthorizeNetClient
    {
        public CustomerProfileClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3) : base(merchantAuthentication, isTestMode, retryCount)
        {
        }

    }
}
