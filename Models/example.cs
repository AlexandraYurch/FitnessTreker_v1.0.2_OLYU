using Microsoft.EntityFrameworkCore;
using NPOI.POIFS.Crypt.Dsig;
using NPOI.SS.Formula.Functions;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static NPOI.SS.Formula.PTG.ArrayPtg;

namespace FitnessTreker_v1._0._2_OLYU.Models
{
    public class example:DbContext
    {
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Post> Posts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Blogging;Trusted_Connection=True");
            optionsBuilder.UseSqlServer(@"data source = D365DEVOLYU; initial catalog = GymDb_1; Trusted_Connection = True; TrustServerCertificate = True;");
            // string connectionstring = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
            //optionsBuilder.UseSqlServer(@connectionstring);
        }

    }
    public class Blog
    {
        public int BlogId { get; set; }
        public string Url { get; set; }
        public int Rating { get; set; }
        public List<Post> Posts { get; set; }
    }

    public class Post
    {
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }

        public int BlogId { get; set; }
        public Blog Blog { get; set; }
    }
}
