using Microsoft.EntityFrameworkCore;
using StarterProject.Api.Common;
using StarterProject.Api.Features.Users;
using StarterProject.Api.Security;

namespace StarterProject.Api.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            : base(options)
        {
        }

        // Declare tables here
        public DbSet<User> Users { get; set; }
        public DbSet<UserClass> UsersClasses { get; set; }
        public DbSet<Class> Classes { get; set; }       
        public DbSet<ClassConcentration> ClassesConcentrations { get; set; }
        public DbSet<Concentration> Concentrations { get; set; }
        public DbSet<Major> Majors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Declare relationships here (xoxo)

            var passwordHasher = new PasswordHash("admin");
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    Role = Constants.Users.Roles.Admin,
                    Username = "admin",
                    Email = "admin@admin.com",
                    FirstName = "Seeded-Admin-FirstName",
                    LastName = "Seeded-Admin-LastName",
                    PasswordHash = passwordHasher.Hash,
                    PasswordSalt = passwordHasher.Salt
                });
        }
    }
}
