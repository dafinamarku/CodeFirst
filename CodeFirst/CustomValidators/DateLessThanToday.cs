using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CodeFirst.CustomValidators
{
  public class DateLessThanToday:ValidationAttribute
  {
    protected override ValidationResult IsValid(object value, ValidationContext validationContext)
    {
      DateTime date = Convert.ToDateTime(value);
      DateTime today = DateTime.Now;
      if (date.Year > today.Year)
      {
        return new ValidationResult(this.ErrorMessage);
      }
      else
      {
        if (today.Year == date.Year && date.Month > today.Month)
        {
          return new ValidationResult(this.ErrorMessage);
        }
        else {
          if (date.Month == today.Month && today.Day < date.Day)
          {
            return new ValidationResult(this.ErrorMessage);
          }
        }
        return ValidationResult.Success;
      }
     
    }
  }
}