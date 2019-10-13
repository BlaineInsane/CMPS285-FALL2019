using FluentValidation;

namespace StarterProject.Api.Features.Classes.Dtos
{
    public class ClassCreateDto
    {
        public string ClassName { get; set; }
        public string ClassDescription { get; set; }
        public int CreditHours { get; set; }
        public string Prerequisite { get; set; }
    }

    public class ClassCreateDtoValidator : AbstractValidator<ClassCreateDto>
    {
        public ClassCreateDtoValidator()
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
