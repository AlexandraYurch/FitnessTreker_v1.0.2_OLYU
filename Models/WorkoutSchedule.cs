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

        public Trainer Trainer { get; set; } = null!;
        public int WorkoutTypeId { get; set; }
        public WorkoutTypes WorkoutType { get; set; }
        [Required]
        public string? WorkoutName { get; set; }
        public string WorkoutDescription { get; set; } = null!;
        [Required]
        [NotMapped]
        public TimeOnly StartWH { get; set; }

        public string StartWHString { get; set; } = null!;
    [NotMapped]
        public TimeOnly EndWH { get; set; }

        [Required]
        public string EndWHString { get; set; } = null!;
    }
}
