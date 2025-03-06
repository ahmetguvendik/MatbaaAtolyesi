using MatbaaAtolyesi.Persistance.Contexts;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace MatbaaAtolyesi.Persistance;

public static class ServiceRegistration
{
    public static void AddPersistanceService(this IServiceCollection collection)
    {
        collection.AddDbContext<MatbaaAtolyesiDbContext>(opt => opt.UseNpgsql("User ID=postgres;Password=testtest;Host=localhost;Port=5432;Database=MatbaaAtolyesiDb;"));
    }
}
