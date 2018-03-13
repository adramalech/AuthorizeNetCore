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
        public void Authentication(string LoginId, string TransactionKey)
        {
            var merchantAuthentication = new MerchantAuthentication()
            {
                LoginId = LoginId,
                TransactionKey = TransactionKey
            };

            AuthorizeNetClient client = new AuthorizeNetClient(merchantAuthentication, isTestMode: true);

            var result = client.TestAuthentication().Result;

            Assert.True(
                result != null && result.Messages != null && result.Messages.Message != null &&
                !string.IsNullOrEmpty(result.Messages.ResultCode) && result.Messages.ResultCode == "Ok" && !string.IsNullOrEmpty(result.Messages.Message.Code)
            );
        }
    }
}
