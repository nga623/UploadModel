using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace UploadModel.EntityFrameworkCore
{
    public class UploadModelHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<UploadModelHttpApiHostMigrationsDbContext>
    {
        public UploadModelHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
        {
            var configuration = BuildConfiguration();

            var builder = new DbContextOptionsBuilder<UploadModelHttpApiHostMigrationsDbContext>()
                .UseSqlServer(configuration.GetConnectionString("UploadModel"));

            return new UploadModelHttpApiHostMigrationsDbContext(builder.Options);
        }

        private static IConfigurationRoot BuildConfiguration()
        {
            var builder = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json", optional: false);

            return builder.Build();
        }
    }
}
