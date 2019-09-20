namespace StarterProject.Api.Features.Users
{
    public class UserClass
    {
        public int Id { get; set; }
        public int UserId { get; set; } // FK to Users table
        public int ClassId { get; set; } // FK to Classes table
        public int Grade { get; set; }
        public bool ClassCompleted { get; set; }
    }
}