using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace VOLKSWAGEN.UnitTest.Helpers
{
    public class FakeHttpMessageHandler : HttpMessageHandler
    {
        public virtual HttpResponseMessage Send(HttpRequestMessage request)
        {
            throw new NotImplementedException("Will not execute. it's just for mocking");
        }

        protected override Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            return Task.FromResult(Send(request));
        }
    }
}