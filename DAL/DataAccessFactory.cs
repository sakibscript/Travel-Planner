using DAL.EF.Tables;
using DAL.Interfaces;
using DAL.Repos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public class DataAccessFactory
    {
        public static IRepo<User, int, User> UserData()
        {
            return new UserRepo();
        }
        public static IRepo<Trip, int, Trip> TripDetails()
        {
            return new TripRepo();
        }
        public static IRepo<Budget, int, Budget> BudgetDetails()
        {
            return new BudgetRepo();
        }
        public static IRepo<Packing, int, Packing> PackingDetails()
        {
            return new PackingRepo();
        }
        public static ITripFeatures TripFeatures()
        {
            return new TripRepo();
        }
        public static IBudgetFeatures BudgetFeatures()
        {
            return new BudgetRepo();
        }
        public static IPackingFeatures PackingFeatures()
        {
            return new PackingRepo();
        }
    }
}
