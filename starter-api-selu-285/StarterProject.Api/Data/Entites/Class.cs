using System.Collections.Generic;

namespace StarterProject.Api.Features.Users
{
    public class Class
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int CreditHours { get; set; }
        public string Prerequisite { get; set; }

        public List<UserClass> UsersClasses { get; set; }
        public List<ClassConcentration> ClassesConcentrations { get; set; }
    }
}