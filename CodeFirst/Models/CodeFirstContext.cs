using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;


namespace CodeFirst.Models
{
  public class CodeFirstContext:DbContext
  {
    public CodeFirstContext():base("CodeFirstCon")
    {    }

    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }
    public DbSet<Brand> Brands { get; set; }
  }
}