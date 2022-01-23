using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LordOftheWings.DAL.Models
{
    [Table("Dishes")]
    public class Dish
    {
        public long ID  { get; set; }
        public string DishName { get; set; }
        public float Price { get; set; }
        public long DishTypeID { get; set; }

        public virtual DishType Type { get; set; }
    }
}
