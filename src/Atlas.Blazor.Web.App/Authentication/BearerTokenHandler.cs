using System.Net.Http.Headers;
using Atlas.Core.Interfaces;

namespace Atlas.Blazor.Web.App.Authentication
{
    public class BearerTokenHandler(ITokenProvider tokenProvider) : DelegatingHandler
    {
        private readonly ITokenProvider _tokenProvider = tokenProvider;

        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
        {
            string? accessToken = await _tokenProvider.GetAccessTokenAsync().ConfigureAwait(false);

            if (!string.IsNullOrWhiteSpace(accessToken))
            {
                request.Headers.Authorization = new AuthenticationHeaderValue("Bearer", accessToken);
            }

            return await base.SendAsync(request, cancellationToken);
        }
    }
}
