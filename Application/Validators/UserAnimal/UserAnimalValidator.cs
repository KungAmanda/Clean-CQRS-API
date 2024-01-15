using Application.Dtos;
using FluentValidation;

namespace Application.Validators.UserAnimal
{
    public class UserAnimalValidator : AbstractValidator<UserAnimalDto>
    {
        public UserAnimalValidator()
        {
            RuleFor(userAnimal => userAnimal.AnimalId)
                .NotEmpty().WithMessage("AnimalId name cannot be empty!")
                .NotNull().WithMessage("AnimalId name cannot be null!");

            RuleFor(userAnimal => userAnimal.UserId)
                .NotEmpty().WithMessage("UserId name cannot be empty!")
                .NotNull().WithMessage("UserId name cannot be null!");
        }
    }
}
