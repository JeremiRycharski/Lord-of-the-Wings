using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LordOftheWings.DAL.Models
{
    [Table("Orders")]
    public class Order
    {
        public long ID { get; set; }
        public long TableID { get; set; }

        public virtual Table Table { get; set; }
        public virtual ICollection<OrderedDish> OrderedDishes { get; set; }
    }
}
