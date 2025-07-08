using AutoMapper;
using BLL.DTOs;
using DAL;
using DAL.EF.Tables;
using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Services
{
    public class UserService
    {
        public static Mapper GetMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                cfg.CreateMap<User, UserDTO>();
                cfg.CreateMap<UserDTO, User>();
            });
            return new Mapper(config);
        }
        public static UserDTO Add(UserDTO u) {
            var repo = DataAccessFactory.UserData();
            var user = repo.Add(GetMapper().Map<User>(u));
            return GetMapper().Map<UserDTO>(user);
        }
        
        public static UserDTO View(int id) {
            var repo = DataAccessFactory.UserData();
            var user = repo.View(id);
            return GetMapper().Map<UserDTO>(user);
        }
        public static List<UserDTO>View()
        {
            var repo = DataAccessFactory.UserData();
            var user = repo.View();
            return GetMapper().Map<List<UserDTO>>(user);
        }
        public static UserDTO Edit(UserDTO u)
        {
            var repo = DataAccessFactory.UserData();
            var user = repo.Edit(GetMapper().Map<User>(u));
            return GetMapper().Map<UserDTO>(user);
        }
        public static bool Delete(int id)
        {
            var repo = DataAccessFactory.UserData();
            return repo.Delete(id);
        }
    }
}
