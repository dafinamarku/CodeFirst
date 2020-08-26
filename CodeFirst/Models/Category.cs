using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeFirst.Models
{
  public class Category
  {
    public long CategoryID { get; set; }
    public string CategoryName { get; set; }

    public virtual ICollection<Product> Products { get; set; }
  }
}