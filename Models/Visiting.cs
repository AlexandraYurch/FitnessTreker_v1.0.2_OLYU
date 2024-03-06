using System.ComponentModel.DataAnnotations;

namespace FitnessTreker_v1._0._2_OLYU.Models
{
    public class Visiting
    {


        [Required]
        public int Id { get; set; }

        public bool IsVisited { get; set; }

        public ICollection<WorkoutSchedule> WorkoutSchedules { get; set; }

         //public ICollection<User> Users { get; set; }
         public int UserId { get; set; }
         public User User { get; set; }
         

    }
}
