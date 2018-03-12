using AuthorizeNetCore;
using AuthorizeNetCore.Models;
using Xunit;

namespace AuthorizeNetCoreTest
{
    public class AuthorizeNetClientTest
    {
        protected string LoginId = "";
        protected string TransactionKey = "";

        [Fact]
        public void Authentication()
        {
            var merchantAuthentication = new MerchantAuthentication()
            {
                LoginId = "",
                TransactionKey = ""
            };

            AuthorizeNetClient client = new AuthorizeNetClient(merchantAuthentication, true);

            var result = client.TestAuthentication();

            Assert.True(!string.IsNullOrEmpty(result));
        }
    }
}
