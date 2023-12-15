using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Cats.DeleteCat
{
    public class DeleteCatByIdCommandHandler : IRequestHandler<DeleteCatByIdCommand, Cat>
    {
        private readonly RealDatabase _realDatabase;

        public DeleteCatByIdCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<Cat> Handle(DeleteCatByIdCommand request, CancellationToken cancellationToken)
        {

            var catToDelete = _realDatabase.Cats.FirstOrDefault(cat => cat.Id == request.Id);

            if (catToDelete != null)
            {
                _realDatabase.Cats.Remove(catToDelete);

            }
            else
            {

                throw new InvalidOperationException("No cat with the given ID was found.");
            }

            _realDatabase.SaveChangesAsync(cancellationToken);

            return Task.FromResult(catToDelete);
        }
    }
}
