using Microsoft.EntityFrameworkCore;
using Volo.Abp.Data;
using Volo.Abp.EntityFrameworkCore;

namespace UploadModel.EntityFrameworkCore
{
    [ConnectionStringName(UploadModelDbProperties.ConnectionStringName)]
    public class UploadModelDbContext : AbpDbContext<UploadModelDbContext>, IUploadModelDbContext
    {
        /* Add DbSet for each Aggregate Root here. Example:
         * public DbSet<Question> Questions { get; set; }
         */

        public UploadModelDbContext(DbContextOptions<UploadModelDbContext> options) 
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ConfigureUploadModel();
        }
    }
}