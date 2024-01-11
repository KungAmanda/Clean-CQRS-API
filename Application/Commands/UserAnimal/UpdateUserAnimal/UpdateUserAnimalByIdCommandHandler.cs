using Application.Commands.Cats.UpdateCat;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.UserAnimal.UpdateUserAnimal
{
    public class UpdateUserAnimalByIdCommandHandler : IRequestHandler<UpdateUserAnimalByIdCommand, UserAnimalModel>
    {
        private readonly RealDatabase _realDatabase;

        public UpdateUserAnimalByIdCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<UserAnimalModel> Handle(UpdateUserAnimalByIdCommand request, CancellationToken cancellationToken)
        {
            UserAnimalModel userAnimalToUpdate = _realDatabase.UserAnimals.FirstOrDefault(UserAnimal => UserAnimal.Key == request.Key)!;

            userAnimalToUpdate.UserId = request.UpdateUserAnimal.UserId;
            userAnimalToUpdate.AnimalId = request.UpdateUserAnimal.AnimalId;



            _realDatabase.SaveChangesAsync(cancellationToken);


            return Task.FromResult(userAnimalToUpdate);
        }

    }
}
