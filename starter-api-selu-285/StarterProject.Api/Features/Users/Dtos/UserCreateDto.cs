using FluentValidation;

namespace StarterProject.Api.Features.Users.Dtos
{
    public class UserCreateDto
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public int? StartYear { get; set; }
        public string Password { get; set; }
    }

    public class UserCreateDtoValidator : AbstractValidator<UserCreateDto>
    {
        public UserCreateDtoValidator()
        {
            RuleFor(x => x.FirstName)
                .NotEmpty()
                .Matches(@"^[\w'\-\s]*$"); // only accept "alphanumeric ' -";

            RuleFor(x => x.LastName)
                .NotEmpty()
                .Matches(@"^[\w'\-\s]*$"); // only accept "alphanumeric ' -";

            RuleFor(x => x.Username)
                .NotEmpty()
                .Matches(@"^[\w'\-_\s]*$"); // only accept "alphanumeric ' - _";

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