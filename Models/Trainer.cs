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
    public class TrainerContext : AppDbContext
    {
        public TrainerContext(DbContextOptions<AppDbContext> options) : base(options) 
        { 
        }
        public DbSet<Trainer> Trainers { get; set; }
    }
   
    public class Trainer
    {
        public int TrainerId { get; set; }
        [Required]
        public string? TrainerName { get; set; }
        [Required]
        public string? TrainerLastName { get; set; }

    }
}
