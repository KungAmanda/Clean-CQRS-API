using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Users.UpdateUser
{
    public class UpdateUserByIdCommandHandler : IRequestHandler<UpdateUserByIdCommand, User>
    {
        private readonly RealDatabase _realDatabase;

        public UpdateUserByIdCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<User> Handle(UpdateUserByIdCommand request, CancellationToken cancellationToken)
        {
            User userToUpdate = _realDatabase.Users.FirstOrDefault(user => user.Id == request.Id)!;

            userToUpdate.Username = request.UpdatedUser.Username;
            userToUpdate.PasswordHash = request.UpdatedUser.Password;


            _realDatabase.SaveChangesAsync(cancellationToken);

            return Task.FromResult(userToUpdate);

        }
    }
}
