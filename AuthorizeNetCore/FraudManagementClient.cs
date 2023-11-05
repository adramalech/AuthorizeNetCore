using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.Authentication;

namespace AuthorizeNetCore
{
    public class FraudManagementClient : AuthorizeNetClient
    {
        public FraudManagementClient(MerchantAuthentication merchantAuthentication, bool isTestMode) : base(merchantAuthentication, isTestMode)
        {
        }

    }
}
