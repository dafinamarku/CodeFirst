using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using CodeFirst.CustomValidators;

namespace CodeFirst.Models
{
  public class Product
  {
    public long ProductID { get; set; }
    [Required]
    [RegularExpression(@"^[A-Za-z ]*$", ErrorMessage = "The name must contain only letters.")]
    [MaxLength(20, ErrorMessage ="Name can not be more than 20 letters.")]
    public string ProductName { get; set; }
    [Required]
    [Range(0,100000, ErrorMessage ="Price should be between 0 and 100000.")]
    public Nullable<decimal> Price { get; set; }
    [DateLessThanToday(ErrorMessage ="Date of purchase shuld be less than or equal than today's date.")]
    public Nullable<System.DateTime> DateOfPurchase { get; set; }
    public string AvailabilityStatus { get; set; }
    [Required]
    public Nullable<long> CategoryID { get; set; }
    [Required]
    public Nullable<long> BrandID { get; set; }
    public Nullable<bool> Active { get; set; }

    public virtual Brand Brand { get; set; }
    public virtual Category Category { get; set; }
  }
}