﻿using MathNet.Numerics.Distributions;
using System.ComponentModel.DataAnnotations;


namespace FitnessTreker_v1._0._2_OLYU.Models
{
    public class Workout
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public int WorkoutScheduleId { get; set; }
        
        public Workout()
        {
            WorkoutSchedules = new List<WorkoutSchedule>();

        }
        public IList<WorkoutSchedule> WorkoutSchedules { get; set; }
    }
}
