using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;

using System.Threading.Tasks;
using FitnessTrecker_v._1._0._2_Business.Interfaces;
using FitnessTreker_v1._0._2_OLYU.Models;
using FitnessTreker_v1._0._2_OLYU.Data;
using Microsoft.EntityFrameworkCore;

namespace FitnessTrecker_v._1._0._2_Business
{
    public class UserRepository : IUserRepository
    {
        private Gym context;
        public UserRepository(Gym context) { this.context = context; }
        public void DeleteUser(int userId)
        {
            User user = context.Find<User>(userId);
            context.Users.Remove(user);
            //throw new NotImplementedException();
        }

        public User GetUserById(int userId)
        {
            return context.Users.Find(userId);
            //throw new NotImplementedException();
        }

        public void InsertUser(User user)
        {
            context.Users.Add(user);
           // throw new NotImplementedException();
        }

        public void UpdateUser(User user)
        {
            context.Entry(user).State = EntityState.Modified;
            //throw new NotImplementedException();
        }
        public void Save()
        {
            context.SaveChanges();
        }
    }
}
