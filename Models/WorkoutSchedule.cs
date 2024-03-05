using System.ComponentModel.DataAnnotations;


namespace FitnessTreker_v1._0._2_OLYU.Models
{
    public class WorkoutSchedule
    {
        [Required]
        public int Id { get; set; }

        public int WorkoutId { get; set; }
        public ICollection<Workout> Workouts { get; set; }
        public ICollection<Schedule> Schedules { get; set; }
    }
}
