using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace AuthorizeNetCore.Utils
{
    public class RetryMessageHandler : DelegatingHandler
    {
        private readonly int _retryCount;

        /// <summary>
        /// This will allow creation of a custom HttpMessageHandler with a specific number of retries.
        /// </summary>
        /// <param name="handler">The custom http message handler.</param>
        /// <param name="retryCount">The amount of retries in seconds.</param>
        public RetryMessageHandler(HttpMessageHandler handler, int retryCount) : base(handler)
        {
            _retryCount = retryCount;
        }

        /// <summary>
        /// Default Http Message Handler with a specific timeout period.
        /// </summary>
        /// <param name="retryCount"></param>
        public RetryMessageHandler(int retryCount) : this(new HttpClientHandler(), retryCount)
        {
        }

        /// <summary>
        /// Send HTTP Request and only retry a finite time only for timeouts.
        /// </summary>
        /// <param name="request">The http request object.</param>
        /// <param name="cancellationToken">The token that allows for the async task to be cancelled.</param>
        /// <returns>The response message of the respective request.</returns>
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            HttpResponseMessage response = null;

            for (var i = 1; i <= _retryCount; i++)
            {
                response = await base.SendAsync(request, cancellationToken);

                //if not a timeout code or if task cancelled then return.
                if (cancellationToken.IsCancellationRequested || !(response.StatusCode == HttpStatusCode.GatewayTimeout && response.StatusCode == HttpStatusCode.RequestTimeout))
                {
                    return response;
                }

                //this will wait 5 seconds on first retry, 20 seconds on second, and 45 seconds on third, 
                //80 seconds on fourth, 125 seconds on fifth, etc.. etc..
                await Task.Delay(_retryCount^2 * 5000);
            }

            //if still timing out after retry count has been met return timeout response.
            return response;
        }       
    }
}
