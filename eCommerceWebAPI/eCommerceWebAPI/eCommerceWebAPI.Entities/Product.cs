using System;
using System.Collections.Generic;

namespace eCommerceWebAPI.Entities
{
  public enum Sizes { XS, S, M, L, XL };
  public enum Categories { Women, Men, Kids, HomeDeco };

  public class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public Sizes Size { get; set; }
    public Categories Category { get; set; }

  }
}
