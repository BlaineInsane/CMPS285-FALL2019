using FluentValidation;

namespace StarterProject.Api.Features.Classes.Dtos
{
    public class ClassEditDto
    {
        public int Id { get; set; }
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int CreditHours { get; set; }
        public string Prerequisite { get; set; }
    }

    public class ClassEditDtoValidator : AbstractValidator<ClassEditDto>
    {
        public ClassEditDtoValidator()
        {
            RuleFor(x => x.ClassName)
                .NotEmpty();

            RuleFor(x => x.ClassDescription)
                .NotEmpty();

            RuleFor(x => x.CreditHours)
                .NotEmpty();

            RuleFor(x => x.Prerequisite)
                .NotEmpty();
        }
    }
}
