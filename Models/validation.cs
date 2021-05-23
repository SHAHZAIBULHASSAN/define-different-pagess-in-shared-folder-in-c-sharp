using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace shahpractice.Models
{
    public class Validation : ValidationAttribute
        
    {
        protected virtual ValidationResult IsValid(object value, ValidationContext validationContext)
        {   
            if (value!=null)
            {
                string a = value.ToString();
                if (a.Contains("shah"))
                {
                    return ValidationResult.Success;

                }
                ErrorMessage = ErrorMessage ?? validationContext.DisplayName+ "MUST BE FIELD   WRONG";
                return new ValidationResult(ErrorMessage);
            }
        }
    }
}