using FitnessTreker_v1._0._2_OLYU.Data;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks; 

namespace FitnessTreker_v1._0._2_OLYU.Models
{
    public class WorkoutScheduleContext : AppDbContext
    {
        public WorkoutScheduleContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<WorkoutSchedule> WorkoutSchedules { get; set; }
    }

    public class WorkoutSchedule
    {
        public int WorkoutScheduleId { get; set; }

        public ICollection<Workout> Workouts { get; set; }

        [Required]
        public DateTime StartWHString { get; set; }

        [Required]
        public DateTime EndWH { get; set; }
        public int UserScheduleId { get; set; }
        public UserSchedule UserSchedules { get; set; }

        
}
}
