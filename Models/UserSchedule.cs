using System.ComponentModel.DataAnnotations;

namespace FitnessTreker_Domain.Models
{
    public class UserSchedule
    {
        

        [Required]
        public int Id { get; set; }

        public bool Attended { get; set; }

        public ICollection<WorkoutSchedule> WorkoutSchedules { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }


    }
}
