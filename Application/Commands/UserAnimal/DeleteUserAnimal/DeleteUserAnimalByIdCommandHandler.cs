using Application.Commands.Birds.DeleteBird;
using Application.Commands.Cats.DeleteCat;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.Extensions.Logging;
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
        private readonly ILogger<DeleteUserAnimalByIdCommandHandler> _logger;

        public DeleteUserAnimalByIdCommandHandler(RealDatabase realDatabase, ILogger<DeleteUserAnimalByIdCommandHandler> logger)
        {
            _realDatabase = realDatabase;
            _logger = logger;
        }

        public Task<UserAnimalModel> Handle(DeleteUserAnimalByIdCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var userAnimalToDelete = _realDatabase.UserAnimals.FirstOrDefault(userAnimals => userAnimals.Key == request.Key);

                if (userAnimalToDelete != null)
                {
                    _realDatabase.UserAnimals.Remove(userAnimalToDelete);
                    _realDatabase.SaveChangesAsync(cancellationToken);
                    _logger.LogInformation("Relation deleted!", userAnimalToDelete.Key);

                }
                else
                {
                    _logger.LogWarning("No relation with the given key was found.");
                    throw new InvalidOperationException("No relation with the given key was found.");
                }



                return Task.FromResult(userAnimalToDelete);


            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting a relation");
                throw;
            }

        }
    }
}
