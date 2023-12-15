using Domain.Models;
using MediatR;
using Infrastructure.Database;

namespace Application.Commands.Users.DeleteUser
{
    public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, User>
    {
        private readonly RealDatabase _realDatabase;

        public DeleteUserByIdCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<User> Handle(DeleteUserByIdCommand request, CancellationToken cancellationToken)
        {
            var userToDelete = _realDatabase.Users.FirstOrDefault(user => user.Id == request.Id);

            if (userToDelete != null)
            {
                _realDatabase.Users.Remove(userToDelete);
            }
            else
            {
                throw new InvalidOperationException("No user with the given id was found");

            }

            _realDatabase.SaveChangesAsync(cancellationToken);

            return Task.FromResult(userToDelete);
        }


    }
}
