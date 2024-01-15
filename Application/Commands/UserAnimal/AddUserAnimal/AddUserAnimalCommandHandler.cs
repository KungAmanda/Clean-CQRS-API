using Application.Commands.Birds.AddBird;
using Application.Commands.Cats.AddCat;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<AddUserAnimalCommandHandler> _logger;

        public AddUserAnimalCommandHandler(RealDatabase realDatabase, ILogger<AddUserAnimalCommandHandler> logger)
        {
            _realDatabase = realDatabase;
            _logger = logger;
        }


        public async Task<UserAnimalModel> Handle(AddUserAnimalCommand request, CancellationToken cancellationToken)
        {
            try
            {
                UserAnimalModel userAnimalToCreate = new()
                {
                    Key = Guid.NewGuid(),
                    AnimalId = request.NewUserAnimal.AnimalId,
                    UserId = request.NewUserAnimal.UserId

                };



                _realDatabase.UserAnimals.Add(userAnimalToCreate);
                await _realDatabase.SaveChangesAsync(cancellationToken);

                _logger.LogInformation("New relation created!", userAnimalToCreate.Key);


                return userAnimalToCreate;

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new relation");
                throw;
            }


        }
    }
}

