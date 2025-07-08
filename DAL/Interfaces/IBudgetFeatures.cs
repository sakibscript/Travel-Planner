using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IBudgetFeatures
    {
        object GetTotalBudget(int tripId);
        List<object> GetOverBudgetTrips();
        object GetAverageBudgetPerTraveler(int tripId);
    }
}
