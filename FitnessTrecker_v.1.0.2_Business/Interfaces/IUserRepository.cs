using FitnessTreker_v1._0._2_OLYU.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTrecker_v._1._0._2_Business.Interfaces
{
    public interface IUserRepository
    {

        User GetUserById(int userId);
        void InsertUser(User user);
        void DeleteUser(int userId);
        void UpdateUser(User user);
        void Save();
    }
}
