using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class BudgetService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Budget, BudgetDTO>();
                cfg.CreateMap<BudgetDTO, Budget>();
            });
            return new Mapper(config);
        }
        public static BudgetDTO Add(BudgetDTO b)
        {
            var repo = DataAccessFactory.BudgetDetails();
            var budget = repo.Add(GetMapper().Map<Budget>(b));
            return GetMapper().Map<BudgetDTO>(budget);
        }

        public static BudgetDTO View(int id)
        {
            var repo = DataAccessFactory.BudgetDetails();
            var budget = repo.View(id);
            return GetMapper().Map<BudgetDTO>(budget);
        }
        public static List<BudgetDTO> View()
        {
            var repo = DataAccessFactory.BudgetDetails();
            var budget = repo.View();
            return GetMapper().Map<List<BudgetDTO>>(budget);
        }
        public static BudgetDTO Edit(BudgetDTO b)
        {
            var repo = DataAccessFactory.BudgetDetails();
            var budget = repo.Edit(GetMapper().Map<Budget>(b));
            return GetMapper().Map<BudgetDTO>(budget);
        }
        public static bool Delete(int id)
        {
            var repo = DataAccessFactory.BudgetDetails();
            return repo.Delete(id);
        }
        public static object GetTotalBudget(int tripId)
        {
            var repo = DataAccessFactory.BudgetFeatures();
            var budget = repo.GetTotalBudget(tripId);
            return GetMapper().Map<object>(budget);
        }
        public static List<object> GetOverBudgetTrips()
        {
            var repo = DataAccessFactory.BudgetFeatures();
            var budget = repo.GetOverBudgetTrips();
            return GetMapper().Map<List<object>>(budget);
        }
        public static object GetAverageBudgetPerTraveler(int tripId)
        {
            var repo = DataAccessFactory.BudgetFeatures();
            var budget = repo.GetAverageBudgetPerTraveler(tripId);
            return GetMapper().Map<object>(budget);
        }
    }
}
