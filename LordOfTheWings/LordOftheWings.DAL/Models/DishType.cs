using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LordOftheWings.DAL.Models
{
    [Table("DishTypes")]
    public class DishType
    {
        public long ID { get; set; }
        public string TypeDescription { get; set; }
    }
}
