namespace mvcRakuten.Models
{
    using System;
    using System.Configuration;
    using System.Linq;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Design;
    
    public class MySQLDbContext : DbContext
    {
        public DbSet<Member> Member {get; set;}

        public DbSet<Gender> Genders {get; set;}
        
        public DbSet<Property> Property {get; set;}

        private string connectionString {get; set;} = string.Empty;

        public MySQLDbContext(DbContextOptions<MySQLDbContext> options):base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            this.connectionString = "server=10.100.66.34;port=3306;user=root;password=root;database=globall;sslmode=none";
            optionsBuilder.UseMySql(this.connectionString);
        }
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Member>().HasKey(t => t.id);
            modelBuilder.Entity<Gender>().HasKey(t => t.id);
            modelBuilder.Entity<Property>().HasKey(t => t.id);
            //modelBuilder.Entity<Course>().HasKey(t => t.ID);
            //modelBuilder.Entity<StudentCourse>().HasKey(t => new { t.StuID, t.CourseID });

            base.OnModelCreating(modelBuilder);
            modelBuilder.Seed();        
        }
    }
}