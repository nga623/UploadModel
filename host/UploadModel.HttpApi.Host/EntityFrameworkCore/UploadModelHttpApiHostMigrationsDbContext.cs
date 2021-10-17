using Microsoft.EntityFrameworkCore;
using Volo.Abp.EntityFrameworkCore;

namespace UploadModel.EntityFrameworkCore
{
    public class UploadModelHttpApiHostMigrationsDbContext : AbpDbContext<UploadModelHttpApiHostMigrationsDbContext>
    {
        public UploadModelHttpApiHostMigrationsDbContext(DbContextOptions<UploadModelHttpApiHostMigrationsDbContext> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ConfigureUploadModel();
        }
    }
}
