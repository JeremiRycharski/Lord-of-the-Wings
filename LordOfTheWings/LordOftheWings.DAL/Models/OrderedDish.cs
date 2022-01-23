using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LordOftheWings.DAL.Models
{
    [Table("OrderedDishes")]
    public class OrderedDish
    {
        public long ID { get; set; }
        public long OrderID { get; set; }
        public long DishID { get; set; }

        public virtual Dish Dish { get; set; }
        public virtual Order Order { get; set; }
    }
}
