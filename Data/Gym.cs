using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FitnessTreker_v1._0._2_OLYU.Data;
namespace FitnessTreker_v1._0._2_OLYU.Models
{
    public class Gym  : DbContext
    {
 
        public DbSet<Trainer> Trainers { get; set; } = null!;
        public DbSet<User> Users { get; set; } = null!;
        public DbSet<WorkoutSchedule> WorkoutSchedules { get; set; } = null!;
        public DbSet<WorkoutTypes> WorkoutTypes { get; set; } = null!;
      
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"data source=D365DEVOLYU;initial catalog=GymDB;Trusted_Connection=True;TrustServerCertificate=True;");
        }

      

    }
}
