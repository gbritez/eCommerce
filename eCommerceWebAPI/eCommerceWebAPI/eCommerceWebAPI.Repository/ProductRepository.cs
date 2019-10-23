using eCommerceWebAPI.Entities;
using System;
using System.Linq;
using System.Collections.Generic;

namespace eCommerceWebAPI.Repository
{
  public class ProductRepository
  {
    private static ProductRepository repository;
    public static ProductRepository Repository
    {
      get
      {
        if(repository == null)
        {
          repository = new ProductRepository();
        }
        return repository;
      }
     
    }
    public ICollection<Product> Get()
    {
      return new List<Product>() {
       new Product { Id=1, Size= Sizes.M, Category = Categories.HomeDeco},
       new Product { Id=2, Size= Sizes.L, Category = Categories.Kids},
       new Product { Id=3, Size= Sizes.S, Category = Categories.Women},
     }; ;
    }

    public ICollection<Product> GetByCategory(string filter)
    {
      var products = new List<Product>() {
       new Product { Id=1, Size= Sizes.M, Category = Categories.HomeDeco},
       new Product { Id=2, Size= Sizes.L, Category = Categories.Kids},
       new Product { Id=3, Size= Sizes.S, Category = Categories.Women},
     };

      return products.Where(x => Enum.GetName(typeof(Categories), x.Category) == filter).ToList();
    }
  }
}
