using Application.Commands.Birds.AddBird;
using Application.Queries.Dogs.GetAll;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands.Dogs
{
    public class AddDogCommandHandler : IRequestHandler<AddDogCommand, Dog>
    {
        private readonly RealDatabase _realDatabase;
        private readonly ILogger<AddDogCommandHandler> _logger;

        public AddDogCommandHandler(RealDatabase realDatabase, ILogger<AddDogCommandHandler> logger)
        {
            _realDatabase = realDatabase;
            _logger = logger;
        }

        public Task<Dog> Handle(AddDogCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Dog dogToCreate = new()
                {
                    Id = Guid.NewGuid(),
                    Name = request.NewDog.Name,
                    Breed = request.NewDog.Breed,
                    Weight = request.NewDog.Weight
                };

                _realDatabase.Dogs.Add(dogToCreate);
                _realDatabase.SaveChangesAsync(cancellationToken);

                _logger.LogInformation("New dog created: {DogId}", dogToCreate.Id);


                return Task.FromResult(dogToCreate);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new dog");
                throw;
            }
        }
    }
}
