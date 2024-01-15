using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands.Birds.AddBird
{
    public class AddBirdCommandHandler : IRequestHandler<AddBirdCommand, Bird>
    {
        private readonly RealDatabase _realDatabase;
        private readonly ILogger<AddBirdCommandHandler> _logger;

        public AddBirdCommandHandler(RealDatabase realDatabase, ILogger<AddBirdCommandHandler> logger)
        {
            _realDatabase = realDatabase;
            _logger = logger;
        }
        public Task<Bird> Handle(AddBirdCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Bird birdToCreate = new()
                {
                    Id = Guid.NewGuid(),
                    Name = request.NewBird.Name,
                    CanFly = request.NewBird.CanFly,
                    Color = request.NewBird.Color
                };

                _realDatabase.Birds.Add(birdToCreate);
                _realDatabase.SaveChangesAsync(cancellationToken);

                _logger.LogInformation("New bird created: {BirdId}", birdToCreate.Id);

                return Task.FromResult(birdToCreate);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new bird");
                throw;
            }
        }
    }
}
