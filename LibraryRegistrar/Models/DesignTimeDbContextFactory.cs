using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System.IO;

namespace LibraryRegistrar.Models
{
  public class LibraryRegistrarContextFactory : IDesignTimeDbContextFactory<LibraryRegistrarContext>
  {

    LibraryRegistrarContext IDesignTimeDbContextFactory<LibraryRegistrarContext>.CreateDbContext(string[] args)
    {
      IConfigurationRoot configuration = new ConfigurationBuilder()
          .SetBasePath(Directory.GetCurrentDirectory())
          .AddJsonFile("appsettings.json")
          .Build();

      var builder = new DbContextOptionsBuilder<LibraryRegistrarContext>();
      var connectionString = configuration.GetConnectionString("DefaultConnection");

      builder.UseMySql(connectionString);

      return new LibraryRegistrarContext(builder.Options);
    }
  }
}