using UploadModel.Localization;
using Volo.Abp.AspNetCore.Mvc;

namespace UploadModel
{
    public abstract class UploadModelController : AbpController
    {
        protected UploadModelController()
        {
            LocalizationResource = typeof(UploadModelResource);
        }
    }
}
