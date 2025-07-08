using DAL.EF.Tables;
using DAL.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repos
{
    internal class UserRepo: Repo, IRepo<User, int, User>
    {
        public User Add(User u)
        {
            db.Users.Add(u);
            db.SaveChanges();
            return u;
        }

        public User View(int id)
        {
            return db.Users.Find(id);
        }

        public List<User> View()
        {
            return db.Users.ToList();
        }

        public User Edit(User u)
        {
            var ex = View(u.UserID);
            db.Entry(ex).CurrentValues.SetValues(u);
            db.SaveChanges();
            return ex;
        }

        public bool Delete(int id)
        {
            var data = View(id);
            db.Users.Remove(data);
            return db.SaveChanges() > 0;
        }

    }

}
