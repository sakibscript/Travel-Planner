using DAL.EF.Tables;
using DAL.Interfaces;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class TripRepo : Repo, IRepo<Trip, int, Trip>, ITripFeatures
    {
        public Trip Add(Trip t)
        {
            db.Trips.Add(t);
            db.SaveChanges();
            return t;
        }

        public Trip View(int id)
        {
            return db.Trips.Find(id);
        }

        public List<Trip> View()
        {
            return db.Trips.ToList();
        }

        public Trip Edit(Trip t)
        {
            var ex = View(t.TripID);
            db.Entry(ex).CurrentValues.SetValues(t);
            db.SaveChanges();
            return ex;
        }
        public bool Delete(int id)
        {
            var data = View(id);
            db.Trips.Remove(data);
            return db.SaveChanges() > 0;
        }
        public List<Trip> SearchByName(string name)
        {
            return db.Trips.Where(x => x.TripName.Contains(name)).ToList();
        }
        public int Duration(int id)
        {
            var trip = View(id);
            return (trip.EndDate - trip.StartDate).Days + 1;
        }
        public List<Trip> UpcomingTrip()
        {
            var currentDate = DateTime.Now;
            return db.Trips.Where(x => x.StartDate > currentDate).ToList();
        }
        public object GetTripsAndTotals(int year, int month)
        {
            var tripInMonth = db.Trips.Where(x => x.StartDate.Month == month && x.StartDate.Year == year).Select(x => new
            {
                x.TripID,
                x.UserID,
                x.TripName,
                x.Destination,
                x.StartDate,
                x.EndDate
            }).ToList();
            var tripInYear = db.Trips.Where(x => x.StartDate.Year == year).Select(x => new
            {
                x.TripID,
                x.UserID,
                x.TripName,
                x.Destination,
                x.StartDate,
                x.EndDate
            }).ToList();
            var totalTripInMonth = db.Trips.Count(x => x.StartDate.Year == year && x.StartDate.Month == month);
            var totalTripInYear = db.Trips.Count(x => x.StartDate.Year == year);
            return new
            {
                TripInMonth = tripInMonth,
                TripInYear = tripInYear,
                TotalTripInMonth = totalTripInMonth,
                TotalTripInYear = totalTripInYear
            };

        }
        public List<string> RecommendDestinations(int userId)
        {
            var userDestinations = db.Trips
                .Where(t => t.UserID == userId)
                .Select(t => t.Destination).Distinct().ToList();

            var favouriteDestinations = db.Trips
                .Where(t => t.UserID == userId)
                .GroupBy(t => t.Destination)
                .OrderByDescending(t => t.Count())
                .Select(t => t.Key).Take(3).ToList();

            var recommendedDestinations = db.Trips
                .Where(t => !userDestinations.Contains(t.Destination))
                .GroupBy(t => t.Destination)
                .OrderByDescending(t => t.Count())
                .Select(t => t.Key).Take(5).ToList();

            return favouriteDestinations.Concat(recommendedDestinations).Distinct().ToList();
        }
        
        public List<object> GetRatingDistribution()
        {
            var rating = db.Trips.GroupBy(r => r.Rating)
                .Select(r => new
                {
                    Rating = r.Key,
                    TripCount = r.Count()
                })
                .OrderByDescending(r => r.Rating).ToList<object>();
            return rating;
        }
        public List<Trip> SortBy(string sortBy, string order)
        {
            var query = db.Trips.AsQueryable();
            switch (sortBy.ToLower())
            {
                case "tripId":
                    query = order.ToLower() == "asc"
                        ? query.OrderBy(p => p.TripID)
                        : query.OrderByDescending(p => p.TripID);
                    break;

                case "tripName":
                    query = order.ToLower() == "asc"
                        ? query.OrderBy(p => p.TripName)
                        : query.OrderByDescending(p => p.TripName);
                    break;
                case "destination":
                    query = order.ToLower() == "asc"
                        ? query.OrderBy(p => p.Destination)
                        : query.OrderByDescending(p => p.Destination);
                    break;
                case "travelMode":
                    query = order.ToLower() == "asc"
                        ? query.OrderBy(p => p.TravelMode)
                        : query.OrderByDescending(p => p.TravelMode);
                    break;
                case "noOfTravellers":
                    query = order.ToLower() == "asc"
                        ? query.OrderBy(p => p.NoOfTravellers)
                        : query.OrderByDescending(p => p.NoOfTravellers);
                    break;
                case "rating":
                    query = order.ToLower() == "asc"
                        ? query.OrderBy(p => p.Rating)
                        : query.OrderByDescending(p => p.Rating);
                    break;
                default:
                    return db.Trips.ToList();
            }
            return query.ToList();
        }
        public List<Trip> DisplayByPage(int page, int pageSize)
        {
            return db.Trips.OrderBy(p => p.TripID).Skip((page - 1) * pageSize).Take(pageSize).ToList();
        }

        public byte[] GenerateTripItineraryPdf(int tripId)
        {
            var trip = db.Trips.FirstOrDefault(t => t.TripID == tripId);

            if (trip == null)
            {
                throw new ArgumentException("Trip not found.");
            }

            using (var memoryStream = new MemoryStream())
            {
                PdfWriter writer = new PdfWriter(memoryStream);
                PdfDocument pdfDoc = new PdfDocument(writer);
                Document document = new Document(pdfDoc);

                // Add Title
                document.Add(new Paragraph($"Trip Itinerary for Trip ID: {trip.TripID}")

                    .SetFontSize(16));

                // Add Trip Details
                document.Add(new Paragraph($"Trip Name: {trip.TripName}"));
                document.Add(new Paragraph($"Destination: {trip.Destination}"));
                document.Add(new Paragraph($"Travel Mode: {trip.TravelMode}"));
                document.Add(new Paragraph($"Number of Travelers: {trip.NoOfTravellers}"));
                document.Add(new Paragraph($"Start Date: {trip.StartDate.ToShortDateString()}"));
                document.Add(new Paragraph($"End Date: {trip.EndDate.ToShortDateString()}"));
                document.Add(new Paragraph($"Itinerary Summary: {trip.ItinerarySummary}"));
                document.Add(new Paragraph($"Rating: {trip.Rating}"));

                document.Close();
                return memoryStream.ToArray();
            }
        }
    }

}
