using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Budget
    {
        public int BudgetID { get; set; }

        [ForeignKey("Trip")]
        public int TripID { get; set; }
        public string Category { get; set; }
        public double EstimatedCost { get; set; }
        public double? ActualCost { get; set; }

        public Trip Trip { get; set; }


    }
}
