using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessTreker_v1._0._2_OLYU.Models
{
    public class example2:DbContext
    {
        public DbSet<Student> Students { get; set; }
        public DbSet<Grade> Grades { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
            optionsBuilder.UseSqlServer(@"data source = D365DEVOLYU; initial catalog = GymDB_3; Trusted_Connection = True; TrustServerCertificate = True;");
            // string connectionstring = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            //optionsBuilder.UseSqlServer(@connectionstring);
        }
    }

    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public int GradeId { get; set; }
        public Grade Grade { get; set; }


    }

    public class Grade
    {
        public Grade()
        {
            Students = new List<Student>();
        }

        public int GradeId { get; set; }
        public string GradeName { get; set; }

        public IList<Student> Students { get; set; }
    }
}
