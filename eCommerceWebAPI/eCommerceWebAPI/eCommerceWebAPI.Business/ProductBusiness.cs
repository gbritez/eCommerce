using eCommerceWebAPI.Entities;
using eCommerceWebAPI.Repository;
using System;
using System.Collections.Generic;

namespace eCommerceWebAPI.Business
{
  public class ProductBusiness
  {
    public ICollection<Product> Get()
    {
      return ProductRepository.Repository.Get();
    }

    public ICollection<Product> GetByCategory(string filter)
    {
      return ProductRepository.Repository.GetByCategory(filter);
    }
  }
}
