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
    public class WorkoutContext : AppDbContext
    {
        public WorkoutContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<Workout> Workouts { get; set; }
    }
    public class Workout 
    {
        [Required]
        public int WorkoutId { get; set; }
        [Required]
        public string WorkoutName { get; set; } = null!;

        public int WorkoutScheduleId { get; set; }
        
        public WorkoutSchedule WorkoutSchedules { get; set; }
    }
}
