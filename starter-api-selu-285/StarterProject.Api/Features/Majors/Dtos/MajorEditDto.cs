using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Features.Majors.Dtos
{
    public class MajorEditDto
    {
        public int Id { get; set; }
        public string MajorName { get; set; }
    }

    public class MajorEditDtoValidator : AbstractValidator<MajorEditDto>
    {
        public MajorEditDtoValidator()
        {
            RuleFor(x => x.MajorName)
                .NotEmpty();

        }
    }
}
