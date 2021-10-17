using UploadModel.Localization;
using Volo.Abp.AspNetCore.Mvc.UI.RazorPages;

namespace UploadModel.Web.Pages
{
    /* Inherit your PageModel classes from this class.
     */
    public abstract class UploadModelPageModel : AbpPageModel
    {
        protected UploadModelPageModel()
        {
            LocalizationResourceType = typeof(UploadModelResource);
            ObjectMapperContext = typeof(UploadModelWebModule);
        }
    }
}