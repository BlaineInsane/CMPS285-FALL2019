using System.Collections.Generic;


namespace StarterProject.Api.Features.Users
{
    public class Major
    {
        public int Id { get; set; }
        public string MajorName { get; set; }

        public List<Concentration> Concentrations { get; set; }
    }
}
