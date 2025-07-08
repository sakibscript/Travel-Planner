using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iText.Commons.Actions.Data;

namespace BLL.Services
{
    public class TripService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Trip, TripDTO>();
                cfg.CreateMap<TripDTO, Trip>();
            });
            return new Mapper(config);
        }
        public static TripDTO Add(TripDTO t)
        {
            var repo = DataAccessFactory.TripDetails();
            var trip = repo.Add(GetMapper().Map<Trip>(t));
            return GetMapper().Map<TripDTO>(trip);
        }

        public static TripDTO View(int id)
        {
            var repo = DataAccessFactory.TripDetails();
            var trip = repo.View(id);
            return GetMapper().Map<TripDTO>(trip);
        }
        public static List<TripDTO> View()
        {
            var repo = DataAccessFactory.TripDetails();
            var trip = repo.View();
            return GetMapper().Map<List<TripDTO>>(trip);
        }
        public static TripDTO Edit(TripDTO t)
        {
            var repo = DataAccessFactory.TripDetails();
            var trip = repo.Edit(GetMapper().Map<Trip>(t));
            return GetMapper().Map<TripDTO>(trip);
        }
        public static bool Delete(int id)
        {
            var repo = DataAccessFactory.TripDetails();
            return repo.Delete(id);
        }
        public static List<TripDTO> SearchByName(string name)
        {
            var repo = DataAccessFactory.TripFeatures();
            var trip = repo.SearchByName(name);
            return GetMapper().Map<List<TripDTO>>(trip);
        }
        public static int Duration(int id)
        {
            var repo = DataAccessFactory.TripFeatures();
            var trip = repo.Duration(id);
            return GetMapper().Map<int>(trip);
        }
        public static List<TripDTO> UpcomingTrip()
        {
            var repo = DataAccessFactory.TripFeatures();
            var trip = repo.UpcomingTrip();
            return GetMapper().Map<List<TripDTO>>(trip);
        }
        public static object GetTripsAndTotals(int year, int month)
        {
            var repo = DataAccessFactory.TripFeatures();
            var trip = repo.GetTripsAndTotals(year, month);
            return GetMapper().Map<object>(trip);
        }
        public static List<string> RecommendDestinations(int userId)
        {
            var repo = DataAccessFactory.TripFeatures();
            var trip = repo .RecommendDestinations(userId);
            return GetMapper().Map<List<string>>(trip);
        }
        public static byte[] GenerateTripItineraryPdf(int tripId)
        {
            var repo = DataAccessFactory.TripFeatures();
            var pdf = repo.GenerateTripItineraryPdf(tripId);
            return GetMapper().Map<byte[]>(pdf);
        }
        public static List<object> GetRatingDistribution()
        {
            var repo = DataAccessFactory.TripFeatures();
            var rating = repo.GetRatingDistribution();
            return GetMapper().Map<List<object>>(rating);
        }
        public static List<TripDTO> SortBy(string sortBy, string order)
        {
            var repo = DataAccessFactory.TripFeatures();
            var trip = repo.SortBy(sortBy, order);
            return GetMapper().Map<List<TripDTO>>(trip);
        }
        public static List<TripDTO> DisplayByPage(int page, int pageSize)
        {
            var repo = DataAccessFactory.TripFeatures();
            var trip = (repo.DisplayByPage(page, pageSize));
            return GetMapper().Map<List<TripDTO>>(trip);
        }

    }
}
