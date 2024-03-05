using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTreker_Domain.Models;
using System.Configuration;

namespace FitnessTreker_Domain.Data
{
    public class Gym  : DbContext
    {
 
       
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<WorkoutSchedule> WorkoutSchedules { get; set; } = null!;
        public DbSet<Workout> Workouts { get; set; } = null!;
        public DbSet<UserSchedule> UserSchedules { get; set; } = null!;
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionstring = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            optionsBuilder.UseSqlServer(@connectionstring);
        }

      

    }
}
