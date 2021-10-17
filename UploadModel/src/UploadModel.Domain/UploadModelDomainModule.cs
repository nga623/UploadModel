using Volo.Abp.Domain;
using Volo.Abp.Modularity;

namespace UploadModel
{
    [DependsOn(
        typeof(AbpDddDomainModule),
        typeof(UploadModelDomainSharedModule)
    )]
    public class UploadModelDomainModule : AbpModule
    {

    }
}
