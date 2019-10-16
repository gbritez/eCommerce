using eCommerceAPI.Common;
using Microsoft.EntityFrameworkCore;
using System;

namespace eCommerceAPI.Repository
{
  public class AppContext : DbContext
  {
    public DbSet<ProductModel> Products { get; set; }
    public AppContext() { }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-PR1IQJB7; Initial Catalog=eCommerceDB; Integrated Security = true");
    }

  }
}
