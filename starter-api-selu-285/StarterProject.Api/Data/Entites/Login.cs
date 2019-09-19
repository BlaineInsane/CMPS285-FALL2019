namespace StarterProject.Api.Features.Users
{
    public class Login
    {
        public int LoginId { get; set; }
        public int StudentId { get; set; }
        public string LoginName { get; set; }
        public byte[] PasswordHash { get; set; }
        public byte[] PasswordSalt { get; set; }
    }
}