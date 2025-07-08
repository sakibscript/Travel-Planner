using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Interfaces
{
    public interface IPackingFeatures
    {
        object GetPackingHistory(int userId);
        bool DuplicatePackingList(int sourceTripId, int destinationTripId);
    }
}
