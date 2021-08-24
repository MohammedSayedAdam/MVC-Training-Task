using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMBTask.Models
{
    public class FoodItem
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        [StringLength(255, ErrorMessage = "Must be between 10 and 255 characters", MinimumLength = 10)]
        public string Name { get; set; }
        public float Price { get; set; }
        public string Description { get; set; }
    }
}