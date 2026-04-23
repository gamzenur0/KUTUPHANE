using Kutuphane.cs.Models;
using KUTUPHANE.Models;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        public DbSet<Book> Books { get; set; }
        public DbSet<Kategori> Kategoriler { get; set; }

    }
}