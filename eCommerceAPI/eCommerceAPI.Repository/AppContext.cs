using eCommerceAPI.Entities;
using Microsoft.EntityFrameworkCore;
using System;

namespace eCommerceAPI.Repository
{
  public class AppContext : DbContext
  {
    public DbSet<ProductEntity> Products { get; set; }
    public AppContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Data Source=.; Initial Catalog=eCommerceDB; Integrated Security = true");
    }

  }
}
