using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    public class PackingRepo : Repo, IRepo<Packing, int, Packing>, IPackingFeatures
    {
        public Packing Add(Packing p)
        {
            db.Packings.Add(p);
            db.SaveChanges();
            return p;
        }

        public Packing View(int id)
        {
            return db.Packings.Find(id);
        }

        public List<Packing> View()
        {
            return db.Packings.ToList();
        }

        public Packing Edit(Packing p)
        {
            var ex = View(p.PackingItemID);
            db.Entry(ex).CurrentValues.SetValues(p);
            db.SaveChanges();
            return ex;
        }
        public bool Delete(int id)
        {
            var data = View(id);
            db.Packings.Remove(data);
            return db.SaveChanges() > 0;
        }
        public object GetPackingHistory(int userId)
        {
            var pastPacking = db.Trips
                              .Where(t => t.UserID == userId)
                              .Select(t => t.TripID).ToList();

            if (!pastPacking.Any())
            {
                return new List<object>();
            }
            var packing = db.Packings.Where(p => pastPacking.Contains(p.TripID) && p.IsPacked)
                                     .Select(p => new
                                     {
                                         p.TripID,
                                         p.ItemName,
                                         p.Quantity,
                                         p.Priority,
                                     }).ToList();
            return packing;
        }
        public bool DuplicatePackingList(int sourceTripId, int destinationTripId)
        {
            var sourceItem = db.Packings.Where(p => p.TripID == sourceTripId).ToList();
            foreach (var item in sourceItem)
            {
                var newItem = new Packing
                {
                    TripID = destinationTripId,
                    ItemName = item.ItemName,
                    Quantity = item.Quantity,
                    Priority = item.Priority,
                    IsPacked = false,
                };
                db.Packings.Add(newItem);
            }
            return db.SaveChanges() > 0;
        }
    }
}
