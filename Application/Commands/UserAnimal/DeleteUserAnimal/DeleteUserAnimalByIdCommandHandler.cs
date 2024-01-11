using Application.Commands.Cats.DeleteCat;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.UserAnimal.DeleteUserAnimal
{
    public class DeleteUserAnimalByIdCommandHandler : IRequestHandler<DeleteUserAnimalByIdCommand, UserAnimalModel>
    {
        private readonly RealDatabase _realDatabase;

        public DeleteUserAnimalByIdCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<UserAnimalModel> Handle(DeleteUserAnimalByIdCommand request, CancellationToken cancellationToken)
        {

            var userAnimalToDelete = _realDatabase.UserAnimals.FirstOrDefault(userAnimals => userAnimals.Key == request.Key);

            if (userAnimalToDelete != null)
            {
                _realDatabase.UserAnimals.Remove(userAnimalToDelete);

            }
            else
            {

                throw new InvalidOperationException("No relation with the given key was found.");
            }

            _realDatabase.SaveChangesAsync(cancellationToken);

            return Task.FromResult(userAnimalToDelete);
        }
    }
}
