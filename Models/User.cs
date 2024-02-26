using System.ComponentModel.DataAnnotations;

namespace FitnessTreker_Domain.Models
{ 
    public class User
    {
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; } = null!;
        public string LastName { get; set; } = null!;

        public int TelegramId { get; set; }
        public UserSchedule UserSchedules { get; set; }

    }
}
