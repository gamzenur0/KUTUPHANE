using Kutuphane.cs.Models;
using Microsoft.EntityFrameworkCore;

namespace Kutuphane.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)

        {
        }

     public DbSet<Book> Books { get; set; }

    }
}