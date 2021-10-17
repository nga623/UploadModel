using Microsoft.Extensions.DependencyInjection;
using UploadModel.Blazor.Menus;
using Volo.Abp.AspNetCore.Components.Web.Theming;
using Volo.Abp.AspNetCore.Components.Web.Theming.Routing;
using Volo.Abp.AutoMapper;
using Volo.Abp.Modularity;
using Volo.Abp.UI.Navigation;

namespace UploadModel.Blazor
{
    [DependsOn(
        typeof(UploadModelApplicationContractsModule),
        typeof(AbpAspNetCoreComponentsWebThemingModule),
        typeof(AbpAutoMapperModule)
        )]
    public class UploadModelBlazorModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {
            context.Services.AddAutoMapperObjectMapper<UploadModelBlazorModule>();

            Configure<AbpAutoMapperOptions>(options =>
            {
                options.AddProfile<UploadModelBlazorAutoMapperProfile>(validate: true);
            });

            Configure<AbpNavigationOptions>(options =>
            {
                options.MenuContributors.Add(new UploadModelMenuContributor());
            });

            Configure<AbpRouterOptions>(options =>
            {
                options.AdditionalAssemblies.Add(typeof(UploadModelBlazorModule).Assembly);
            });
        }
    }
}