using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Data.Contexts;

public class DataContextFactory : IDesignTimeDbContextFactory<DataContext>
{
    public DataContext CreateDbContext(string[] args)
{
    var optionsBuilder = new DbContextOptionsBuilder<DataContext>();
    optionsBuilder.UseSqlServer("Server=tcp:sql-erickarlsson-win23-jsbackend.database.windows.net,1433;Initial Catalog=identity_database;Persist Security Info=False;User ID=SqlAdmin;Password=zonk40Gadd;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

    return new DataContext(optionsBuilder.Options);
}
}
