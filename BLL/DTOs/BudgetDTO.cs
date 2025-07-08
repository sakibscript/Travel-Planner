using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class BudgetDTO
    {
        public int BudgetID { get; set; }
        public int TripID { get; set; }
        public string Category { get; set; }
        public double EstimatedCost { get; set; }
        public double? ActualCost { get; set; }
    }
}
