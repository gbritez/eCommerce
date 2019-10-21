using eCommerceAPI.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace eCommerceAPI.Repository
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


    public ICollection<ProductModel> GetAll()
    {
      ICollection<ProductModel> result = null;

      using (var context = new AppContext())
      {
        result = context.Products.ToList();
      }

      return result;
    }

    public ProductModel Get(int id)
    {
      ProductModel result = null;

      using ( var context = new AppContext())
      {
        result = context.Products.Find(id);
      }

      return result;
    }

  }
}
