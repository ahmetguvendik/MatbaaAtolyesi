using MatbaaAtolyesi.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace MatbaaAtolyesi.Persistance;

public class DesignTimeDbContext : IDesignTimeDbContextFactory<MatbaaAtolyesiDbContext>
{
    public MatbaaAtolyesiDbContext CreateDbContext(string[] args)
    {
        DbContextOptionsBuilder<MatbaaAtolyesiDbContext> dbContextOptions = new();
        dbContextOptions.UseNpgsql("User ID=postgres;Password=testtest;Host=localhost;Port=5432;Database=MatbaaAtolyesiDb;");
        return new(dbContextOptions.Options);
    }
}