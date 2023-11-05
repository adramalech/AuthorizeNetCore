using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.Authentication;

namespace AuthorizeNetCore
{
    public class TransactionReportingClient : AuthorizeNetClient
    {
        public TransactionReportingClient(MerchantAuthentication merchantAuthentication, bool isTestMode) : base(merchantAuthentication, isTestMode)
        {
        }

    }
}
