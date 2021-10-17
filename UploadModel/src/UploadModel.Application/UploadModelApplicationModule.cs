using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.Application;
using Volo.Abp.BlobStoring;

namespace UploadModel
{
    [DependsOn(
        typeof(UploadModelDomainModule),
        typeof(UploadModelApplicationContractsModule),
        typeof(AbpDddApplicationModule),
        typeof(AbpBlobStoringModule),
        typeof(AbpAutoMapperModule)
        )]
    public class UploadModelApplicationModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<UploadModelApplicationModule>();
            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddMaps<UploadModelApplicationModule>(validate: true);
            });
        }
    }
}
