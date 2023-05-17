using JobPortal_API.Models;
using Microsoft.EntityFrameworkCore;

namespace JobPortal_API.Data
{
    public class ApplicationDbContext:DbContext
    {
        
                public ApplicationDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
        public DbSet<UserRole> UserRoles { get; set; }
        public DbSet<JobListing> JobListings { get; set; }
        public DbSet<Application> Applications { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<UserRole>().HasData(
            new UserRole
            {
                UserRoleId = 1, 
                UserRoleName = "Recruiter"      
            },
                new UserRole
                {
                    UserRoleId = 2, 
                    UserRoleName = "Applicant"      
                }

            );

        }
    }
}
