using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace BMBTask.Models
{
    public class Order
    {
        public int Id { get; set; }
        public string Number { get; set; }
        [Required(ErrorMessage = "Restaurant is Required")]
        public Restaurant Restaurant { get; set; }
       
        public string Name { get; set; }
        [Required(ErrorMessage = "FoodItem is Required To make an order")]
        public virtual List<FoodItem> FoodItems { get; set; }
    }
}