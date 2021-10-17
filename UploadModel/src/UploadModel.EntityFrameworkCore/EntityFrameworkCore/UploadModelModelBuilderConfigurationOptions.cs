using JetBrains.Annotations;
using Volo.Abp.EntityFrameworkCore.Modeling;

namespace UploadModel.EntityFrameworkCore
{
    public class UploadModelModelBuilderConfigurationOptions : AbpModelBuilderConfigurationOptions
    {
        public UploadModelModelBuilderConfigurationOptions(
            [NotNull] string tablePrefix = "",
            [CanBeNull] string schema = null)
            : base(
                tablePrefix,
                schema)
        {

        }
    }
}