using MathNet.Numerics.Distributions;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTreker_v1._0._2_OLYU.Models
{
    public class Schedule
    {
        [Required]
        public int Id { get; set; }

        public DateTime Date { get; set; }

        [Required]
        public DateTime StartEndWH { get; set; }

        public Schedule()
        {
            WorkoutSchedules = new List<WorkoutSchedule>();
        }
        public IList<WorkoutSchedule> WorkoutSchedules { get; set; }
    }
}
