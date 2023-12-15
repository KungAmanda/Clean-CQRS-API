using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Users.GetById
{
    public class GetUserByIdQueryHandler : IRequestHandler<GetUserByIdQuery, User>
    {
        private readonly RealDatabase _realDatabase;
        public GetUserByIdQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<User> Handle(GetUserByIdQuery request, CancellationToken cancellationToken)
        {
            User wantedUser = _realDatabase.Users.FirstOrDefault(user => user.Id == request.Id)!;
            return Task.FromResult(wantedUser);
        }
    }
}
