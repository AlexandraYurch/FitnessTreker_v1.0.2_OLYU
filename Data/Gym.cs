using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using FitnessTreker_v1._0._2_OLYU.Models;
using System.Diagnostics;

namespace FitnessTreker_v1._0._2_OLYU.Data
{
    public class Gym : DbContext
    {

        //public Gym(DbContextOptions<Gym> options) : base(options) { }
        public DbSet<User> Users { get; set; }
        public DbSet<WorkoutSchedule> WorkoutSchedules { get; set; }
        public DbSet<Workout> Workouts { get; set; }
        public DbSet<Visiting> Visitings { get; set; }
        public DbSet<Schedule> Schedules { get; set; }

        

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
           // Debugger.Launch();
            //string connectionstring = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            //optionsBuilder.UseSqlServer(@connectionstring);
            optionsBuilder.UseSqlServer(@"data source = D365DEVOLYU; initial catalog = GymDb_1; Trusted_Connection = True; TrustServerCertificate = True;");
        }



    }
}
