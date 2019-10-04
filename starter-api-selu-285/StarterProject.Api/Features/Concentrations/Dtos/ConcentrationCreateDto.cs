using FluentValidation;

namespace StarterProject.Api.Features.Concentrations.Dtos
{
    public class ConcentrationCreateDto
    {
        public string ConcentrationName { get; set; }
        public int MajorId { get; set; }
    }

    public class ConcentrationCreateDtoValidator : AbstractValidator<ConcentrationCreateDto>
    {
        public ConcentrationCreateDtoValidator()
        {
            RuleFor(x => x.ConcentrationName)
                .NotEmpty();
        }
    }
}
