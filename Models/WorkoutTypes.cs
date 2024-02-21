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
    public class WorkoutTypesContext : AppDbContext
    {
        public WorkoutTypesContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }
        public DbSet<WorkoutTypes> WorkoutTypes { get; set; }
    }
    public class WorkoutTypes
    {
        [Key]
       public int WorkoutTypeId { get; set; }
        [Required]
        public string? WorkoutName { get; set; }
        public ICollection<WorkoutSchedule> WorkoutSchedules { get; set; }

}
}
