using System.Collections.Generic;

namespace StarterProject.Api.Features.Users
{
    public class Concentration
    {
        public int Id { get; set; }
        public string ConcentrationName { get; set; }

        public List<ClassConcentration> ClassesConcentrations { get; set; }

        public int MajorId { get; set; } // FK to Major table
        public Major Major { get; set; }
    }
}
