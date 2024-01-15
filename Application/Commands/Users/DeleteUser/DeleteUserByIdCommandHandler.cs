using Domain.Models;
using MediatR;
using Infrastructure.Database;
using Application.Commands.Birds.AddBird;
using Microsoft.Extensions.Logging;

namespace Application.Commands.Users.DeleteUser
{
    public class DeleteUserByIdCommandHandler : IRequestHandler<DeleteUserByIdCommand, User>
    {
        private readonly RealDatabase _realDatabase;
        private readonly ILogger<DeleteUserByIdCommandHandler> _logger;

        public DeleteUserByIdCommandHandler(RealDatabase realDatabase, ILogger<DeleteUserByIdCommandHandler> logger)
        {
            _realDatabase = realDatabase;
            _logger = logger;
        }

        public Task<User> Handle(DeleteUserByIdCommand request, CancellationToken cancellationToken)
        {
            try
            {
                var userToDelete = _realDatabase.Users.FirstOrDefault(user => user.Id == request.Id);

                if (userToDelete != null)
                {
                    _realDatabase.Users.Remove(userToDelete);
                    _realDatabase.SaveChangesAsync(cancellationToken);
                    _logger.LogInformation("User deleted: {UserId}", userToDelete.Id);
                }
                else
                {
                    _logger.LogWarning("No User with the given ID was found.");
                    throw new InvalidOperationException("No user with the given id was found");

                }



                return Task.FromResult(userToDelete);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error occurred while deleting a user");
                throw;
            }
        }


    }
}
