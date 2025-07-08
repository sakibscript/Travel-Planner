using AutoMapper;
using BLL.DTOs;
using DAL.EF.Tables;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class PackingService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<Packing, PackingDTO>();
                cfg.CreateMap<PackingDTO, Packing>();
            });
            return new Mapper(config);
        }
        public static PackingDTO Add(PackingDTO p)
        {
            var repo = DataAccessFactory.PackingDetails();
            var packing = repo.Add(GetMapper().Map<Packing>(p));
            return GetMapper().Map<PackingDTO>(packing);
        }

        public static PackingDTO View(int id)
        {
            var repo = DataAccessFactory.PackingDetails();
            var packing = repo.View(id);
            return GetMapper().Map<PackingDTO>(packing);
        }
        public static List<PackingDTO> View()
        {
            var repo = DataAccessFactory.PackingDetails();
            var packing = repo.View();
            return GetMapper().Map<List<PackingDTO>>(packing);
        }
        public static PackingDTO Edit(PackingDTO p)
        {
            var repo = DataAccessFactory.PackingDetails();
            var packing = repo.Edit(GetMapper().Map<Packing>(p));
            return GetMapper().Map<PackingDTO>(packing);
        }
        public static bool Delete(int id)
        {
            var repo = DataAccessFactory.PackingDetails();
            return repo.Delete(id);
        }
        public static object GetPackingHistory(int userId)
        {
            var repo = DataAccessFactory.PackingFeatures();
            var packing = repo.GetPackingHistory(userId);
            return GetMapper().Map<object>(packing);
        }
        public static bool DuplicatePackingList(int sourceTripId, int destinationTripId)
        {
            var repo = DataAccessFactory.PackingFeatures();
            var packing = repo.DuplicatePackingList(sourceTripId, destinationTripId);
            return GetMapper().Map<bool>(packing);
        }
    }
}
