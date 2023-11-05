using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.Authentication;

namespace AuthorizeNetCore
{
    public class CustomerProfileClient : AuthorizeNetClient
    {
        public CustomerProfileClient(MerchantAuthentication merchantAuthentication, bool isTestMode) : base(merchantAuthentication, isTestMode)
        {
        }

    }
}
