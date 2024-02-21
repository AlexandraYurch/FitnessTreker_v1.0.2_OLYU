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
   
    public class UserScheduleContext : AppDbContext
    {
        public UserScheduleContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<UserSchedule> UserSchedules { get; set; }
    }
    public class UserSchedule
    {
        public ICollection<User> Users { get; set; }

        [Required]
        public int UserScheduleId { get; set; }
        [Required]
        public string UserTelegramId { get; set; }

        public string UserFullName { get; set; } = null!;

        public bool Attended { get; set; }


        public ICollection<Workout> Workouts { get; set; }


    }
}
