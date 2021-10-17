using Volo.Abp.AspNetCore.Components.WebAssembly.Theming;
using Volo.Abp.Modularity;

namespace UploadModel.Blazor.WebAssembly
{
    [DependsOn(
        typeof(UploadModelBlazorModule),
        typeof(UploadModelHttpApiClientModule),
        typeof(AbpAspNetCoreComponentsWebAssemblyThemingModule)
        )]
    public class UploadModelBlazorWebAssemblyModule : AbpModule
    {
        
    }
}