using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMBTask.Models
{
    public class Customer
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(255, ErrorMessage = "Must be between 10 and 255 characters", MinimumLength = 10)]
        public string Name { get; set; }
        [Required(ErrorMessage = "UserName is Required")]
        [StringLength(255, ErrorMessage = "Must be between 10 and 255 characters", MinimumLength = 10)]
        [System.Web.Mvc.Remote("IsUserExists", "Customers", ErrorMessage = "User Name already in use")]

        public string UserName { get; set; }

        [Required(ErrorMessage = "Password is Required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required(ErrorMessage = "Confirm Password is Required")]
        [StringLength(255, ErrorMessage = "Must be between 5 and 255 characters", MinimumLength = 5)]
        [DataType(DataType.Password)]
        [Compare("Password")]
        public string ConfirmPassword { get; set; }
        [Required(ErrorMessage = "Email is Required")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public virtual List<Order> Orders { get; set; }
    }

    
}