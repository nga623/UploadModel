using System;
using Volo.Abp;
using Volo.Abp.MongoDB;

namespace UploadModel.MongoDB
{
    public static class UploadModelMongoDbContextExtensions
    {
        public static void ConfigureUploadModel(
            this IMongoModelBuilder builder,
            Action<AbpMongoModelBuilderConfigurationOptions> optionsAction = null)
        {
            Check.NotNull(builder, nameof(builder));

            var options = new UploadModelMongoModelBuilderConfigurationOptions(
                UploadModelDbProperties.DbTablePrefix
            );

            optionsAction?.Invoke(options);
        }
    }
}