

namespace StarterProject.Api.Features.Classes.Dtos
{
    public class ClassGetDto
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int CreditHours { get; set; }
        public string Prerequisite { get; set; }
    }
}