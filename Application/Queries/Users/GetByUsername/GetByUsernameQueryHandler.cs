using MediatR;
using System.Threading;
using System.Threading.Tasks;
using Domain.Models;
using Microsoft.EntityFrameworkCore;
using Infrastructure.Database;
using Application.Queries.Users.GetByUsername;

namespace Application.Queries.Users.GetByUsername
{
    public class GetByUsernameQueryHandler : IRequestHandler<GetByUsernameQuery, User>
    {
        private readonly RealDatabase _realDatabase;

        public GetByUsernameQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public async Task<User> Handle(GetByUsernameQuery request, CancellationToken cancellationToken)
        {

            var user = await _realDatabase.Users.FirstOrDefaultAsync(u => u.Username == request.Username, cancellationToken);

            return user;
        }
    }
}
