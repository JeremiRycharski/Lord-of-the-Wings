using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LordOftheWings.DAL.Models
{
    [Table("Tables")]
    public class Table
    {
        public long ID { get; set; }
        public int Seatings { get; set; }
    }
}
