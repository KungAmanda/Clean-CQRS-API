using Application.Dtos;
using FluentValidation;

namespace Application.Validators.User
{
    public class UserValidator : AbstractValidator<UserDto>
    {
        public UserValidator()
        {
            RuleFor(user => user.Username)
                .NotEmpty().WithMessage("Username cannot be empty!")
                .NotNull().WithMessage("Username cannot be null!");
        }
    }
}
