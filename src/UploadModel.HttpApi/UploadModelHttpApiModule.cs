using Localization.Resources.AbpUi;
using UploadModel.Localization;
using Volo.Abp.AspNetCore.Mvc;
using Volo.Abp.Localization;
using Volo.Abp.Modularity;
using Microsoft.Extensions.DependencyInjection;
using Volo.Abp.BlobStoring;

namespace UploadModel
{
    [DependsOn(
        typeof(UploadModelApplicationContractsModule),
        typeof(AbpBlobStoringModule),
        typeof(AbpAspNetCoreMvcModule))]
    public class UploadModelHttpApiModule : AbpModule
    {
        public override void PreConfigureServices(ServiceConfigurationContext context)
        {
            PreConfigure<IMvcBuilder>(mvcBuilder =>
            {
                mvcBuilder.AddApplicationPartIfNotExists(typeof(UploadModelHttpApiModule).Assembly);
            });
        }

        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            Configure<AbpLocalizationOptions>(options =>
            {
                options.Resources
                    .Get<UploadModelResource>()
                    .AddBaseTypes(typeof(AbpUiResource));
            });
        }
    }
}
