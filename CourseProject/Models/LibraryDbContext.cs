using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;

namespace CourseProject.Models
{
    public class LibraryDbContext : DbContext
    {
        public LibraryDbContext()
            :base("LibraryDbConnection")
        { }

        public DbSet<Books> Books{ get; set; }
        public DbSet<Authors> Authprs { get; set; }
        public DbSet<Checks> Checks { get; set; }
        public DbSet<Readers> Readers { get; set; }
        public DbSet<Serieses> BookSerieses { get; set; }


    }
}
