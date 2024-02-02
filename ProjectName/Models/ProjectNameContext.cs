using Microsoft.EntityFrameworkCore;

namespace ProjectName.Models
{
  public class ProjectNameContext : DbContext
  {
    public DbSet<Item> Items { get; set; }
 
    public ProjectNameContext(DbContextOptions options) : base(options) { }
  }
}