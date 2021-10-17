using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace UploadModel.EntityFrameworkCore
{
    [ConnectionStringName(UploadModelDbProperties.ConnectionStringName)]
    public interface IUploadModelDbContext : IEfCoreDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * DbSet<Question> Questions { get; }
         */
    }
}