using System.ComponentModel.DataAnnotations;


namespace FitnessTreker_Domain.Models
{
    public class Workout 
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }

        public int WorkoutScheduleId { get; set; }
        
        public WorkoutSchedule WorkoutSchedules { get; set; }
    }
}
