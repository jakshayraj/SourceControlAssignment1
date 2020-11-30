using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using SourceControlAssignment1.CustomValidation;
using System.ComponentModel;

namespace SourceControlAssignment1.Models
{
    public class Employee
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is Required")]
        [StringLength(50, MinimumLength = 3)]
        public string Name { get; set; }
        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Password is Required")]
        [MaxLength(10)]
        [MinLength(3)]
        public string Password { get; set; }
        [Required(ErrorMessage = "Age is Required")]
        [Range(1, 80, ErrorMessage = "Age must be between 1-80 in years.")]
        public int Age { get; set; }
        [Required(ErrorMessage = "Email Id is Required")]
        [EmailAddress(ErrorMessage = "Invalid Email Address")]
        public string Emailid { get; set; }
        [Required(ErrorMessage = "Email Id is Required")]
        [RegularExpression(@"[a-z0-9._%+-]+@[a-z0-9.-]+\.[a-z]{2,4}", ErrorMessage = "Incorrect Email Format")]
        [DisplayName("Second Emaild")]
        public string Second_Email { get; set; }
        
        [Required(ErrorMessage = "Please enter hire date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [CustomHireDate]
        public DateTime HireDate { get; set; }
        
        [Required(ErrorMessage = "Credit card is Required")]
        [CreditCard(ErrorMessage = "Invalid credit card no.")]
        [DisplayName("Credit Card")]
        public int Credit_card { get; set; }
        [Required(ErrorMessage = "Phone no is Required")]
        [Phone(ErrorMessage = "Invalid Phone no")]
        public int Phone { get; set; }
    }
}
