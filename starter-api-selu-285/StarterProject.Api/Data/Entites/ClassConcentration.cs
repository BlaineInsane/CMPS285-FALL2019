namespace StarterProject.Api.Features.Users
{
    public class ClassConcentration
    {
        public int Id { get; set; }
        public int ClassId { get; set; } // FK to Classes table
        public int ConcentrationId { get; set; } // FK to concentrations table
    }
}