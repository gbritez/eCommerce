using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eCommerceWebAPI.Business;
using eCommerceWebAPI.Entities;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace eCommerceWebAPI.Controllers
{
  [Route("[controller]/[action]")]
  [ApiController]
  public class ProductsController : ControllerBase
  {
    private ProductBusiness business;
    private ProductBusiness Business
    {
      get
      {
        if (business == null)
        {
          business = new ProductBusiness();
        }
        return business;
      }
    }

    [HttpGet]
    public ActionResult<ICollection<Product>> Get()
    {
      List<Product> results = new List<Product>();
      try
      {
        results = Business.Get().ToList();
      }
      catch (Exception ex)
      {
        throw;
      }
      return results;
    }

    [HttpGet]
    public ActionResult<ICollection<Product>> GetByCategory([FromQuery]string filter)
    {
      List<Product> results = new List<Product>();
      try
      {
        results = Business.GetByCategory(filter).ToList();
      }
      catch (Exception ex)
      {
        throw;
      }
      return results;
    }
  }
}
