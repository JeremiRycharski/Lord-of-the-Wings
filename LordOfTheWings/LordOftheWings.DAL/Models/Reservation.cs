using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace LordOftheWings.DAL.Models
{
    [Table("Reservation")]
    public class Reservation
    {
        public long ID { get; set; }
        public int PeopleCount { get; set; }
        public string ReservedBy { get; set; }
        public int ContactNumber { get; set; }
        public long TableID { get; set; }

        public virtual Table Table { get; set; }
    }
}
