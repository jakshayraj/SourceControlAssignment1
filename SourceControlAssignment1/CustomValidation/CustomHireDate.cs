using System;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel.DataAnnotations;
using System.Web;

namespace SourceControlAssignment1.CustomValidation
{
    public class CustomHireDate : ValidationAttribute
    {
        protected override ValidationResult IsValid(object value, ValidationContext validationContext)
        {
            DateTime CurrentDate = DateTime.Now;
            string Message = string.Empty;
            if (Convert.ToDateTime(value) < CurrentDate)
            {
                Message = "Hire Date cannot be less than current date";
                return new ValidationResult(Message);
            }
            return ValidationResult.Success;
        }
    }
}
