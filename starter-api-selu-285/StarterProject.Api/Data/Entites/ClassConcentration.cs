namespace StarterProject.Api.Features.Users
{
    public class ClassConcentration
    {
        public int ClassConcentrationId { get; set; }

        public int ClassId { get; set; } // FK to Classes table
        public Class Class { get; set; }

        public int ConcentrationId { get; set; } // FK to concentrations table
        public Concentration Concentration { get; set; }
    }
}