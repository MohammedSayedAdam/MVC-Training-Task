using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using BMBTask.Models;
namespace BMBTask.Context
{
    public class RestaurantDbContext : DbContext
    {
        public RestaurantDbContext() : base("RestaurantDbContext")
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<FoodItem> FoodItems { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

    }
}