using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace QMS.PSampleService.EntityFrameworkCore;

public class PSampleServiceHttpApiHostMigrationsDbContextFactory : IDesignTimeDbContextFactory<PSampleServiceHttpApiHostMigrationsDbContext>
{
    public PSampleServiceHttpApiHostMigrationsDbContext CreateDbContext(string[] args)
    {
        var configuration = BuildConfiguration();

        var builder = new DbContextOptionsBuilder<PSampleServiceHttpApiHostMigrationsDbContext>()
            .UseSqlServer(configuration.GetConnectionString("PSampleService"));

        return new PSampleServiceHttpApiHostMigrationsDbContext(builder.Options);
    }

    private static IConfigurationRoot BuildConfiguration()
    {
        var builder = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", optional: false);

        return builder.Build();
    }
}
