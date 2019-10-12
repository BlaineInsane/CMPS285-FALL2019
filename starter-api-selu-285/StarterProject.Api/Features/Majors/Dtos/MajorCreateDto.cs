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
        }
    }
}
