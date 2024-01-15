using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands.Birds.DeleteBird
{
    public class DeleteBirdByIdCommandHandler : IRequestHandler<DeleteBirdByIdCommand, Bird>
    {
        private readonly RealDatabase _realDatabase;
        private readonly ILogger<DeleteBirdByIdCommandHandler> _logger;

        public DeleteBirdByIdCommandHandler(RealDatabase realDatabase, ILogger<DeleteBirdByIdCommandHandler> logger)
        {
            _realDatabase = realDatabase;
            _logger = logger;
        }

        public Task<Bird> Handle(DeleteBirdByIdCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var birdToDelete = _realDatabase.Birds.FirstOrDefault(bird => bird.Id == request.Id);

                if (birdToDelete != null)
                {
                    _realDatabase.Birds.Remove(birdToDelete);
                    _realDatabase.SaveChangesAsync(cancellationToken);
                    _logger.LogInformation("Bird deleted: {BirdId}", birdToDelete.Id);
                }
                else
                {
                    _logger.LogWarning("No bird with the given ID was found.");
                    throw new InvalidOperationException("No bird with the given ID was found.");
                }

                return Task.FromResult(birdToDelete);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting a bird");
                throw;
            }
        }
    }
}
