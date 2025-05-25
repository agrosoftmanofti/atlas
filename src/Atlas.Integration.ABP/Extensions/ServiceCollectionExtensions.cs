using Atlas.Core.Interfaces;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using Volo.Abp.Http.Client;
using Volo.Abp.Identity;

namespace Atlas.Integration.ABP.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAbpIntegration(this IServiceCollection services, IConfiguration configuration)
        {
            services.AddApplication<AtlasAbpIntegrationModule>();

            services.Configure<AbpRemoteServiceOptions>(options =>
            {
                options.RemoteServices.Default.BaseUrl = configuration[Atlas.Core.Constants.Config.REMOTE_SERVICES_DEFAULT];
            });

            services.AddHttpClientProxies(typeof(AbpIdentityHttpApiClientModule).Assembly,
                remoteServiceName: "Default");

            services.TryAddScoped<IUserService, AbpUserService>();
            services.TryAddScoped<ITokenProvider, AbpTokenProvider>();
            return services;
        }
    }
}
