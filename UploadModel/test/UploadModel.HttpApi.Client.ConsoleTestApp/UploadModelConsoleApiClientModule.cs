using Volo.Abp.Http.Client.IdentityModel;
using Volo.Abp.Modularity;

namespace UploadModel
{
    [DependsOn(
        typeof(UploadModelHttpApiClientModule),
        typeof(AbpHttpClientIdentityModelModule)
        )]
    public class UploadModelConsoleApiClientModule : AbpModule
    {
        
    }
}
