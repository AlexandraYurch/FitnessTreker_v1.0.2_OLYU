using FitnessTreker_v1._0._2_OLYU.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTreker_v1._0._2_OLYU.Models
{

    public class UserContext : AppDbContext
    {
        public UserContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<User> Users { get; set; }
    }
    public class User
    {
        public int UserId { get; set; }
        [Required]
        public string? UserName { get; set; } = null!;
        public string UserLastName { get; set; } = null!;

        public int UserTelegramId { get; set; }

        

        public UserSchedule UserSchedules { get; set; }


    }
}
