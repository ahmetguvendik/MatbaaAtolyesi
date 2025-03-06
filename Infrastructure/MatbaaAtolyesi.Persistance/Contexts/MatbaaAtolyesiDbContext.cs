using MatbaaAtolyesi.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace MatbaaAtolyesi.Persistance.Contexts;

public class MatbaaAtolyesiDbContext : DbContext
{
    public MatbaaAtolyesiDbContext(DbContextOptions options) : base(options) { }

    
    public DbSet<Author> Authors { get; set; }
    public DbSet<Blog> Blogs { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<ClientBrand> ClientBrands { get; set; }
    public DbSet<Contact> Contacts { get; set; }
    public DbSet<Newsletter> Newsletters { get; set; }
    public DbSet<Slider> Sliders { get; set; }
    public DbSet<Support> Supports { get; set; }
    public DbSet<Testimonial> Testimonials { get; set; }

}