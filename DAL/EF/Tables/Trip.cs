using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.EF.Tables
{
    public class Trip
    {
        public int TripID { get; set; }

        [ForeignKey("User")]
        public int UserID { get; set; }
        public string TripName { get; set; }
        public string Destination { get; set; }
        public string TravelMode { get; set; }
        public int NoOfTravellers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ItinerarySummary { get; set; }
        public double? Rating { get; set; }
        public User User { get; set; }
        public virtual List<Budget> Budgets { get; set; }
        public virtual List<Packing> Packings { get; set; }
        public Trip()
        {
            Budgets = new List<Budget>();
            Packings = new List<Packing>();
        }
     }
}
