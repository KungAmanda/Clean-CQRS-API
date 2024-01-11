using Application.Commands.Cats.AddCat;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.UserAnimal.AddUserAnimal
{
    public class AddUserAnimalCommandHandler : IRequestHandler<AddUserAnimalCommand, UserAnimalModel>
    {
        private readonly RealDatabase _realDatabase;

        public AddUserAnimalCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }


        public async Task<UserAnimalModel> Handle(AddUserAnimalCommand request, CancellationToken cancellationToken)
        {
            UserAnimalModel userAnimalToCreate = new()
            {
                Key = Guid.NewGuid(),
                AnimalId = request.NewUserAnimal.AnimalId,
                UserId = request.NewUserAnimal.UserId

            };



            _realDatabase.UserAnimals.Add(userAnimalToCreate);
            await _realDatabase.SaveChangesAsync(cancellationToken);


            return userAnimalToCreate;

        }
    }
}

