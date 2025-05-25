using Atlas.Core.Interfaces;
using Volo.Abp.Http.Client.Authentication;

namespace Atlas.Integration.ABP
{
    public class AbpTokenProvider : ITokenProvider
    {
        private readonly IAccessTokenProvider _accessTokenProvider;

        public AbpTokenProvider(IAccessTokenProvider accessTokenProvider)
        {
            _accessTokenProvider = accessTokenProvider;
        }

        public async Task<string?> GetAccessTokenAsync()
        {
            return await _accessTokenProvider.GetAccessTokenAsync();
        }
    }
}
