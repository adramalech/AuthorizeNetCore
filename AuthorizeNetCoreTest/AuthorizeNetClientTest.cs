using AuthorizeNetCore;
using AuthorizeNetCore.Models;
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

            Assert.True(!string.IsNullOrEmpty(result));
        }
    }
}
