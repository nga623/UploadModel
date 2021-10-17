using Volo.Abp.Application;
using Volo.Abp.Modularity;
using Volo.Abp.Authorization;

namespace UploadModel
{
    [DependsOn(
        typeof(UploadModelDomainSharedModule),
        typeof(AbpDddApplicationContractsModule),
        typeof(AbpAuthorizationModule)
        )]
    public class UploadModelApplicationContractsModule : AbpModule
    {

    }
}
