using FluentValidation;

namespace StarterProject.Api.Features.Majors.Dtos
{
    public class MajorCreateDto
    {
        public string MajorName { get; set; }
    }

    public class MajorCreateDtoValidator : AbstractValidator<MajorCreateDto>
    {
        public MajorCreateDtoValidator()
        {
            RuleFor(x => x.MajorName)
                .NotEmpty();

            RuleFor(x => x.MajorName)
                .Matches(@"^[a-zA-Z0-9'\-\s]*$"); // only accept "alphanumeric ' -"
        }
    }
}
