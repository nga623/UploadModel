using JetBrains.Annotations;
using Volo.Abp.MongoDB;

namespace UploadModel.MongoDB
{
    public class UploadModelMongoModelBuilderConfigurationOptions : AbpMongoModelBuilderConfigurationOptions
    {
        public UploadModelMongoModelBuilderConfigurationOptions(
            [NotNull] string collectionPrefix = "")
            : base(collectionPrefix)
        {
        }
    }
}