using Volo.Abp.Bundling;

namespace UploadModel.Blazor.Host
{
    public class UploadModelBlazorHostBundleContributor : IBundleContributor
    {
        public void AddScripts(BundleContext context)
        {

        }

        public void AddStyles(BundleContext context)
        {
            context.Add("main.css", true);
        }
    }
}
