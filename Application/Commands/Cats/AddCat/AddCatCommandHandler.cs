using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands.Cats.AddCat
{
    public class AddCatCommandHandler : IRequestHandler<AddCatCommand, Cat>
    {
        private readonly RealDatabase _realDatabase;
        private readonly ILogger<AddCatCommandHandler> _logger;

        public AddCatCommandHandler(RealDatabase realDatabase, ILogger<AddCatCommandHandler> logger)
        {
            _realDatabase = realDatabase;
            _logger = logger;
        }

        public Task<Cat> Handle(AddCatCommand request, CancellationToken cancellationToken)
        {
            try
            {
                Cat catToCreate = new()
                {
                    Id = Guid.NewGuid(),
                    Name = request.NewCat.Name,
                    LikesToPlay = request.NewCat.LikesToPlay,
                    Breed = request.NewCat.Breed,
                    Weight = request.NewCat.Weight
                };



                _realDatabase.Cats.Add(catToCreate);
                _realDatabase.SaveChangesAsync(cancellationToken);

                _logger.LogInformation("New Cat created: {CatId}", catToCreate.Id);

                return Task.FromResult(catToCreate);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while creating a new cat");
                throw;
            }
        }
    }
}
