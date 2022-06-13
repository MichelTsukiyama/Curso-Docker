using Microsoft.EntityFrameworkCore;
using MVC2.Models;

namespace MVC2.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) {}

        public DbSet<Produto> Produtos {get; set; }
    }
}