using Application.Commands.Birds.DeleteBird;
using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Microsoft.Extensions.Logging;

namespace Application.Commands.Cats.DeleteCat
{
    public class DeleteCatByIdCommandHandler : IRequestHandler<DeleteCatByIdCommand, Cat>
    {
        private readonly RealDatabase _realDatabase;
        private readonly ILogger<DeleteCatByIdCommandHandler> _logger;

        public DeleteCatByIdCommandHandler(RealDatabase realDatabase, ILogger<DeleteCatByIdCommandHandler> logger)
        {
            _realDatabase = realDatabase;
            _logger = logger;
        }

        public Task<Cat> Handle(DeleteCatByIdCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var catToDelete = _realDatabase.Cats.FirstOrDefault(cat => cat.Id == request.Id);

                if (catToDelete != null)
                {
                    _realDatabase.Cats.Remove(catToDelete);
                    _realDatabase.SaveChangesAsync(cancellationToken);
                    _logger.LogInformation("Cat deleted: {CatId}", catToDelete.Id);

                }
                else
                {
                    _logger.LogWarning("No cat with the given ID was found.");
                    throw new InvalidOperationException("No cat with the given ID was found.");
                }

                _realDatabase.SaveChangesAsync(cancellationToken);

                return Task.FromResult(catToDelete);

            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting a cat");
                throw;
            }



        }
    }
}
