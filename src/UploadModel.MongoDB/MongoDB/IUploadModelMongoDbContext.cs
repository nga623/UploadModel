using Volo.Abp.Data;
using Volo.Abp.MongoDB;

namespace UploadModel.MongoDB
{
    [ConnectionStringName(UploadModelDbProperties.ConnectionStringName)]
    public interface IUploadModelMongoDbContext : IAbpMongoDbContext
    {
        /* Define mongo collections here. Example:
         * IMongoCollection<Question> Questions { get; }
         */
    }
}
