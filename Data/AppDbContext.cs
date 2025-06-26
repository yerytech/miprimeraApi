using Microsoft.EntityFrameworkCore;
using MiPrimeraApi.Models;

namespace MiPrimeraApi.Data
{
  public class AppDbContext : DbContext
  {
    public AppDbContext(DbContextOptions<AppDbContext> options) : base(options){}
    public DbSet<Usuario>usuarios=>Set<Usuario>();
  }
}