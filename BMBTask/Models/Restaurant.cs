using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace BMBTask.Models
{
    public class Restaurant
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Name is Required")]
        public string Name { get; set; }
        public string Address { get; set; }
        public virtual List<Employee> Employees { get; set; }
    }
}