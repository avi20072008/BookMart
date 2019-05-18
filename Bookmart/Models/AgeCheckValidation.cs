using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using Bookmart.Models;

namespace Bookmart.Models
{
    public class AgeCheckValidation : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            var sub = (Subscriber)validationContext.ObjectInstance;

            if (sub.BirthDate == null)
                return new ValidationResult("Date Of Birth is required.");

            var age = DateTime.Today.Year - sub.BirthDate.Year;

            return (age >= 18) ? ValidationResult.Success : new ValidationResult(" Subscriber must be atleast 18 years old.");


        }
    }
}