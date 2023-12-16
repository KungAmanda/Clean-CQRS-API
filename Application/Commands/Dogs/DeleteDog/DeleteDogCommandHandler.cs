using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Dogs.DeleteDog
{
    public class DeleteDogByIdCommandHandler : IRequestHandler<DeleteDogByIdCommand, Dog>
    {
        private readonly RealDatabase _realDatabase;

        public DeleteDogByIdCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<Dog> Handle(DeleteDogByIdCommand request, CancellationToken cancellationToken)
        {

            var dogToDelete = _realDatabase.Dogs.FirstOrDefault(dog => dog.Id == request.Id);

            if (dogToDelete != null)
            {
                _realDatabase.Dogs.Remove(dogToDelete);
            }
            else
            {

                throw new InvalidOperationException("No dog with the given ID was found.");
            }

            _realDatabase.SaveChangesAsync(cancellationToken);
            return Task.FromResult(dogToDelete);

        }


    }
}
