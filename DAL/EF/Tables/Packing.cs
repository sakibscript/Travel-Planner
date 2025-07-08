using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Packing
    {
        [Key]
        public int PackingItemID { get; set; }

        [ForeignKey("Trip")]
        public int TripID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Priority { get; set; }
        public bool IsPacked { get; set; }
        public Trip Trip { get; set; }

        public Packing()
        {
            IsPacked = false;
        }
    }
}
