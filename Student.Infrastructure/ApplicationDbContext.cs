using Microsoft.EntityFrameworkCore;
using Student.Domain;
using System.Data;

namespace Student.Infrastructure
{
    public class ApplicationDbContext: DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<StudentInfo>().HasKey(am => new
            {
                am.Id
            });
        }

        public DbSet<StudentInfo> StudentInfo { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder modelBuilder)
        {
            base.OnConfiguring(modelBuilder);
            //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb;Database=SchoolDb;Trusted_Connection=True;");

        }

    }
}
