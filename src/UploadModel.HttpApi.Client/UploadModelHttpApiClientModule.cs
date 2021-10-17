using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.Http.Client;
using Volo.Abp.Modularity;

namespace UploadModel
{
    [DependsOn(
        typeof(UploadModelApplicationContractsModule),
        typeof(AbpHttpClientModule))]
    public class UploadModelHttpApiClientModule : AbpModule
    {
        public const string RemoteServiceName = "UploadModel";

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddHttpClientProxies(
                typeof(UploadModelApplicationContractsModule).Assembly,
                RemoteServiceName
            );
        }
    }
}
