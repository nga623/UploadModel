using Volo.Abp.DependencyInjection;
using Volo.Abp.Ui.Branding;

namespace UploadModel.Blazor.Server.Host
{
    [Dependency(ReplaceServices = true)]
    public class UploadModelBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "UploadModel";
    }
}
