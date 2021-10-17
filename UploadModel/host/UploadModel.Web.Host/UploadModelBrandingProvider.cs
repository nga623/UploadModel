using Volo.Abp.Ui.Branding;
using Volo.Abp.DependencyInjection;

namespace UploadModel
{
    [Dependency(ReplaceServices = true)]
    public class UploadModelBrandingProvider : DefaultBrandingProvider
    {
        public override string AppName => "UploadModel";
    }
}
