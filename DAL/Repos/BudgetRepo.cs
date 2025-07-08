using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace DAL.Repos
{
    public class BudgetRepo : Repo, IRepo<Budget, int, Budget>, IBudgetFeatures
    {
        public Budget Add(Budget b)
        {
            db.Budgets.Add(b);
            db.SaveChanges();
            return b;
        }

        public Budget View(int id)
        {
            return db.Budgets.Find(id);
        }

        public List<Budget> View()
        {
            return db.Budgets.ToList();
        }

        public Budget Edit(Budget b)
        {
            var ex = View(b.BudgetID);
            db.Entry(ex).CurrentValues.SetValues(b);
            db.SaveChanges();
            return ex;
        }
        public bool Delete(int id)
        {
            var data = View(id);
            db.Budgets.Remove(data);
            return db.SaveChanges() > 0;
        }
        public object GetTotalBudget(int tripId)
        {

            var totalEstimatedCost = db.Budgets.Where(b => b.TripID == tripId).Sum(b => b.EstimatedCost);
            var totalActualCost = db.Budgets.Where(b => b.TripID == tripId).Sum(b => b.ActualCost);

            return new
            {
                TripID = tripId,
                TotalEstimatedCost = totalEstimatedCost,
                TotalActualCost = totalActualCost
            };
        }
        public List<object> GetOverBudgetTrips()
        {
            var budget = db.Budgets.GroupBy(b => b.TripID)
                .Where(b => b.Sum(c => c.ActualCost) > b.Sum(c => c.EstimatedCost))
                .Select(b => new
                {
                    TripID = b.Key,
                    TotalEstimatedCost = b.Sum(c => c.EstimatedCost),
                    TotalActualCost = b.Sum(c => c.ActualCost),
                    OverBudgetAmount = b.Sum(c => c.ActualCost) - b.Sum(c => c.EstimatedCost)
                }).ToList<object>();
            return budget;
        }
        public object GetAverageBudgetPerTraveler(int tripId)
        {
            var budget = db.Budgets.Where(b => b.TripID == tripId)
                                   .Join(db.Trips,
                                   b => b.TripID,
                                   t => t.TripID,
                                   (b, t) => new
                                   {
                                       b.EstimatedCost,
                                       b.ActualCost,
                                       t.NoOfTravellers,
                                       t.TripID
                                   })
                                   .GroupBy(g => g.TripID)
                                   .Select(b => new
                                   {
                                       TotalEstimatedCost = b.Sum(c => c.EstimatedCost),
                                       TotalActualCost = b.Sum(c => c.ActualCost),
                                       NoOfTravellers = b.FirstOrDefault().NoOfTravellers,
                                       AverageEstimatedCostPerTraveler = b.Sum(c => c.EstimatedCost) / (b.FirstOrDefault().NoOfTravellers),
                                       AverageActualCostPerTraveler = b.Sum(c => c.ActualCost) / (b.FirstOrDefault().NoOfTravellers),
                                   }).FirstOrDefault();
            return budget;
        }
    }
}
