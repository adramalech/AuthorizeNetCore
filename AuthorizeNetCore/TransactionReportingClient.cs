using AuthorizeNetCore.Models;

namespace AuthorizeNetCore
{
    public class TransactionReportingClient : AuthorizeNetClient
    {
        public TransactionReportingClient(MerchantAuthentication merchantAuthentication, bool isTestMode, int retryCount = 3) : base(merchantAuthentication, isTestMode, retryCount)
        {
        }

    }
}
