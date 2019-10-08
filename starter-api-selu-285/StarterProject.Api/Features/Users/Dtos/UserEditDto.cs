using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StarterProject.Api.Features.Users.Dtos
{
    public class UserEditDto
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public int StartYear { get; set; }
    }

    public class UserEditDtoValidator : AbstractValidator<UserEditDto>
    {
        public UserEditDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty();

            RuleFor(x => x.LastName)
                .NotEmpty();

            RuleFor(x => x.Username)
                .NotEmpty();

            RuleFor(x => x.Email)
                .NotEmpty()
                .EmailAddress();

            RuleFor(x => x.Password)
                .NotEmpty()
                .MinimumLength(6);

            RuleFor(x => x.StartYear)
                .NotEmpty()
                .InclusiveBetween(1925, System.DateTime.Now.Year); //Southeastern starting year and now
        }
    }
}
    