using FluentValidation;

namespace StarterProject.Api.Features.Concentrations.Dtos
{
    public class ConcentrationEditDto
    {
        public string ConcentrationName { get; set; }
        public int MajorId { get; set; }
    }

    public class ConcentrationEditDtoValidator : AbstractValidator<ConcentrationEditDto>
    {
        public ConcentrationEditDtoValidator()
        {
            RuleFor(x => x.ConcentrationName)
                .NotEmpty();
        }
    }
}
