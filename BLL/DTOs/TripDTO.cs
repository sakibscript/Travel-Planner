using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.DTOs
{
    public class TripDTO
    {
        public int TripID { get; set; }
        public int UserID { get; set; }
        public string TripName { get; set; }
        public string Destination { get; set; }
        public string TravelMode { get; set; }
        public int NoOfTravellers { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public string ItinerarySummary { get; set; }
        public double? Rating { get; set; }
    }
}
