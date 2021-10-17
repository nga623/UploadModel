using UploadModel.Localization;
using Volo.Abp.AspNetCore.Components;

namespace UploadModel.Blazor.Server.Host
{
    public abstract class UploadModelComponentBase : AbpComponentBase
    {
        protected UploadModelComponentBase()
        {
            LocalizationResource = typeof(UploadModelResource);
        }
    }
}
