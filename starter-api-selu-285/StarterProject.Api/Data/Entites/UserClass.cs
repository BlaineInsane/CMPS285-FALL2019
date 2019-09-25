
namespace StarterProject.Api.Features.Users
{
    public class UserClass
    {
        public int Id { get; set; }
        public int Grade { get; set; }
        public bool ClassCompleted { get; set; }

        public int UserId { get; set; } // FK to Users table
        public User User { get; set; }

        public int ClassId { get; set; } // FK to Classes table
        public Class Class { get; set; }
    }
}