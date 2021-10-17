using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace UploadModel.MongoDB
{
    [ConnectionStringName(UploadModelDbProperties.ConnectionStringName)]
    public class UploadModelMongoDbContext : AbpMongoDbContext, IUploadModelMongoDbContext
    {
        /* Add mongo collections here. Example:
         * public IMongoCollection<Question> Questions => Collection<Question>();
         */

        protected override void CreateModel(IMongoModelBuilder modelBuilder)
        {
            base.CreateModel(modelBuilder);

            modelBuilder.ConfigureUploadModel();
        }
    }
}