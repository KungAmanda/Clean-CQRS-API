using Application.Commands.Birds.DeleteBird;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands.Dogs.DeleteDog
{
    public class DeleteDogByIdCommandHandler : IRequestHandler<DeleteDogByIdCommand, Dog>
    {
        private readonly RealDatabase _realDatabase;
        private readonly ILogger<DeleteDogByIdCommandHandler> _logger;

        public DeleteDogByIdCommandHandler(RealDatabase realDatabase, ILogger<DeleteDogByIdCommandHandler> logger)
        {
            _realDatabase = realDatabase;
            _logger = logger;
        }

        public Task<Dog> Handle(DeleteDogByIdCommand request, CancellationToken cancellationToken)
        {
            try
            {

                var dogToDelete = _realDatabase.Dogs.FirstOrDefault(dog => dog.Id == request.Id);

                if (dogToDelete != null)
                {
                    _realDatabase.Dogs.Remove(dogToDelete);
                    _realDatabase.SaveChangesAsync(cancellationToken);
                    _logger.LogInformation("Dog deleted: {DogId}", dogToDelete.Id);
                }
                else
                {
                    _logger.LogWarning("No dog with the given ID was found.");
                    throw new InvalidOperationException("No dog with the given ID was found.");
                }


                return Task.FromResult(dogToDelete);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting a dog");
                throw;
            }
        }


    }
}
