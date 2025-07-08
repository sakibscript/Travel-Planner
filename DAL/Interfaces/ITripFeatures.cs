using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface ITripFeatures
    {
        List<Trip> SearchByName(string name);
        int Duration(int id);
        List<Trip> UpcomingTrip();
        object GetTripsAndTotals(int year, int month);
        List<string> RecommendDestinations(int id);
        byte[] GenerateTripItineraryPdf(int tripId);
        List<object> GetRatingDistribution();
        List<Trip> SortBy(string sortBy, string order);
        List<Trip> DisplayByPage(int page, int pageSize);
    }
}
