namespace StarterProject.Api.Features.Users
{
    public class Major
    {
        public int Id { get; set; }
        public string MajornName { get; set; }
        public int ConcentrationId { get; set; } // FK to Concentrations table
    }
}
