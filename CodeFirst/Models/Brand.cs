using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
  public class Brand
  {
    public long BrandID { get; set; }
    public string BrandName { get; set; }

    public virtual ICollection<Product> Products { get; set; }
  }
}