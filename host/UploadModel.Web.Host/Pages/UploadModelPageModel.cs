using UploadModel.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace UploadModel.Pages
{
    public abstract class UploadModelPageModel : AbpPageModel
    {
        protected UploadModelPageModel()
        {
            LocalizationResourceType = typeof(UploadModelResource);
        }
    }
}