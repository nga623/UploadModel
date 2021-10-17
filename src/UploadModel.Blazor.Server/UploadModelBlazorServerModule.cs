using Volo.Abp.AspNetCore.Components.Server.Theming;
using Volo.Abp.Modularity;

namespace UploadModel.Blazor.Server
{
    [DependsOn(
        typeof(AbpAspNetCoreComponentsServerThemingModule),
        typeof(UploadModelBlazorModule)
        )]
    public class UploadModelBlazorServerModule : AbpModule
    {
        
    }
}