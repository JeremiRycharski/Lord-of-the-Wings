using LordOftheWings.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace LordOftheWings.DAL.Context
{
    public class MyAppContext: DbContext
    {
        public MyAppContext(DbContextOptions<MyAppContext> options)
            : base(options) { }

        public virtual DbSet<Dish> Dishes { get; set; }
        public virtual DbSet<DishType> DishTypes { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderedDish> OrderedDishes { get; set; }
        public virtual DbSet<Reservation> Reservations { get; set; }
        public virtual DbSet<Table> Tables { get; set; }


    }
}
