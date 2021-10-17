using Volo.Abp.BlobStoring;
using Volo.Abp.BlobStoring.FileSystem;
using Volo.Abp.Modularity;

namespace UploadModel
{
    [DependsOn(
        typeof(UploadModelApplicationModule),
        typeof(UploadModelDomainTestModule)
        )]
    [DependsOn(typeof(AbpBlobStoringFileSystemModule))]
    public class UploadModelApplicationTestModule : AbpModule
    {
        public override void ConfigureServices(ServiceConfigurationContext context)
        {

            Configure<AbpBlobStoringOptions>(options =>
            {
                options.Containers.ConfigureDefault(container =>
                {
                    container.UseFileSystem(fileSystem =>
                    {
                        fileSystem.BasePath = "D:\\my-files1";
                    });
                });
            });

            base.ConfigureServices(context);
        }
    }
}
