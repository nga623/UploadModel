using UploadModel.Localization;
using Volo.Abp.Application.Services;

namespace UploadModel
{
    public abstract class UploadModelAppService : ApplicationService
    {
        protected UploadModelAppService()
        {
            LocalizationResource = typeof(UploadModelResource);
            ObjectMapperContext = typeof(UploadModelApplicationModule);
        }
    }
}
