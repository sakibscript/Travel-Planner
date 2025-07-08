using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class PackingDTO
    {
        public int PackingItemID { get; set; }
        public int TripID { get; set; }
        public string ItemName { get; set; }
        public int Quantity { get; set; }
        public string Priority { get; set; }
        public bool IsPacked { get; set; }
    }
}
