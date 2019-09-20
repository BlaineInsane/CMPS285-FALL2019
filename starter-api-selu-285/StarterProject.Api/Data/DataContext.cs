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

        // Declare tables here with the form: <singuler name of table> Plural name of table
        public DbSet<User> Users { get; set; }
        public DbSet<UserClass> UsersClasses { get; set; }
        public DbSet<Class> Classes { get; set; }       
        public DbSet<ClassConcentration> ClassesConcentrations { get; set; }
        public DbSet<Concentration> Concentrations { get; set; }
        public DbSet<Major> Majors { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Declare relationships here (xoxo)
            modelBuilder.Entity<UserClass>() // 1(User) to many(UserClass)
                .HasOne(x => x.User)
                .WithMany(x => x.UsersClasses)
                .HasForeignKey(x => x.UserId);
            modelBuilder.Entity<UserClass>() // 1(class) to many(UserClass)
                .HasOne(x => x.Class)
                .WithMany(x => x.UsersClasses)
                .HasForeignKey(x => x.ClassId);

            modelBuilder.Entity<ClassConcentration>() // 1(Class) to many(ClassConcentration)
                .HasOne(x => x.Class)
                .WithMany(x => x.ClassesConcentrations)
                .HasForeignKey(x => x.ClassId);
            modelBuilder.Entity<ClassConcentration>() // 1(Concentration) to many(ClassConcentration)
                .HasOne(x => x.Concentration)
                .WithMany(x => x.ClassesConcentrations)
                .HasForeignKey(x => x.ConcentrationId);

            modelBuilder.Entity<Concentration>() // 1(Major) to many(Concentration)
                .HasOne(x => x.Major)
                .WithMany(x => x.Concentrations)
                .HasForeignKey(x => x.MajorId);

            // End of relationships 

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
