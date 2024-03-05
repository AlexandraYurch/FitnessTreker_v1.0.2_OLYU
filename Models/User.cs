using System.ComponentModel.DataAnnotations;

namespace FitnessTreker_v1._0._2_OLYU.Models
{
    public class User
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string? Name { get; set; } = null!;
        public string? LastName { get; set; } = null!;

        public int TelegramId { get; set; }
        public Visiting Visitings { get; set; }

    }
}
