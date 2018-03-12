using AuthorizeNetCore.Models;

namespace AuthorizeNetCore
{
    public class FraudManagementClient : AuthorizeNetClient
    {
        public FraudManagementClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3) : base(merchantAuthentication, isTestMode, retryCount)
        {
        }

    }
}
