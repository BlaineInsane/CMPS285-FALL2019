﻿using FluentValidation;

namespace StarterProject.Api.Features.ClassesConcentrations.Dtos
{
    public class ClassConcentrationCreateDto
    {
        public int ClassId { get; set; }
        public int ConcentrationId { get; set; }
    }

    public class ClassConcentrationCreateDtoValidator : AbstractValidator<ClassConcentrationCreateDto>
    {
        public ClassConcentrationCreateDtoValidator()
        {
            RuleFor(x => x.ClassId)
                .NotEmpty();

            RuleFor(x => x.ConcentrationId)
                .NotEmpty();
        }
    }
}