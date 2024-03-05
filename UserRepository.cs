
using FitnessTrecker_Domain.Interfaces;
using Microsoft.EntityFrameworkCore;
using FitnessTreker_Domain.Data;
using FitnessTreker_Domain.Models;

namespace FitnessTrecker_Domain
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
