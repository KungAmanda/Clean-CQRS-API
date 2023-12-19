using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Domain.Models;
using Infrastructure.Database;
using Application.Commands.Users.RegisterUser;
using BCrypt.Net;

namespace Application.Handlers.Users
{
    public class RegisterUserCommandHandler : IRequestHandler<RegisterUserCommand, User>
    {
        private readonly RealDatabase _realDatabase;

        public RegisterUserCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public async Task<User> Handle(RegisterUserCommand request, CancellationToken cancellationToken)
        {
            // Hash the password using BCrypt 
            string passwordHash = BCrypt.Net.BCrypt.HashPassword(request.Password);

            // Create a new user
            var newUser = new User
            {
                Username = request.Username,
                PasswordHash = passwordHash
            };

            // Add the new user to the database
            _realDatabase.Users.Add(newUser);

            // SaveChangesAsync is asynchronous, so you need to await it.
            await _realDatabase.SaveChangesAsync();

            return newUser;
        }
    }
}
