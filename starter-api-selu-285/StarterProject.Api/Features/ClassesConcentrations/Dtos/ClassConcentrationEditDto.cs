using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Features.ClassesConcentrations.Dtos
{
    public class ClassConcentrationEditDto
    {
        public int Id { get; set; }
        public string ClassId { get; set; }
        public string ConcentrationId { get; set; }
    }

    public class ClassConcentrationEditDtoValidator : AbstractValidator<ClassConcentrationEditDto>
    {
        public ClassConcentrationEditDtoValidator()
        {
            RuleFor(x => x.ClassId)
                .NotEmpty();

            RuleFor(x => x.ConcentrationId)
                .NotEmpty();
        }
    }
}
