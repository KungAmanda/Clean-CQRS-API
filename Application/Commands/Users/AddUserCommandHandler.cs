using Domain.Models;
using Infrastructure.Database;
using MediatR;
using Application.Dtos;


namespace Application.Commands.Users.AddUser
{
    public class AddUserCommandHandler : IRequestHandler<AddUserCommand, User>
    {
        private readonly RealDatabase _realDatabase;

        public AddUserCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<User> Handle(AddUserCommand request, CancellationToken cancellationToken)
        {
            User userToCreate = new()
            {
                Id = Guid.NewGuid(),
                Username = request.NewUser.Username,
                PasswordHash = request.NewUser.Password,
               
                
            };

            _realDatabase.Users.Add(userToCreate);

            return Task.FromResult(userToCreate);
        }
    }
}
