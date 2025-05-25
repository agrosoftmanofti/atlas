using Volo.Abp.Modularity;
using Volo.Abp.Http.Client;
using Volo.Abp.Identity;

namespace Atlas.Integration.ABP
{
    [DependsOn(
        typeof(AbpHttpClientModule),
        typeof(AbpIdentityHttpApiClientModule))]
    public class AtlasAbpIntegrationModule : AbpModule
    {
    }
}
