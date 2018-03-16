using AuthorizeNetCore;
using AuthorizeNetCore.Models;
using AuthorizeNetCore.Models.Authentication;
using Xunit;

namespace AuthorizeNetCoreTest
{
    public class AuthorizeNetClientTest
    {
        [Theory]
        [InlineData("", "")]
        public void Authentication(string loginId, string transactionKey)
        {
            var merchantAuthentication = new MerchantAuthentication()
            {
                LoginId = loginId,
                TransactionKey = transactionKey
            };

            AuthorizeNetClient client = new AuthorizeNetClient(merchantAuthentication, isTestMode: true);

            var result = client.TestAuthentication().Result;

            Assert.True(result?.Messages?.Message != null && !string.IsNullOrEmpty(result.Messages.ResultCode) && result.Messages.ResultCode == "Ok");
        }
    }
}
