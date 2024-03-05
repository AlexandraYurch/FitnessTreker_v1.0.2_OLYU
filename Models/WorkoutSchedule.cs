using System.ComponentModel.DataAnnotations;


namespace FitnessTreker_Domain.Models
{
    public class WorkoutSchedule
    {
        public int Id { get; set; }

        public int WorkoutId { get; set; }

        [Required]
        public DateTime StartWH { get; set; }

        [Required]
        public DateTime EndWH { get; set; }
        public int UserScheduleId { get; set; }
        public UserSchedule UserSchedules { get; set; }   
    }
}
