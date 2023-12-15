using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Users.GetAll
{
    public class GetAllUsersQueryHandler : IRequestHandler<GetAllUsersQuery, List<User>>
    {
        private readonly RealDatabase _realDatabase;

        public GetAllUsersQueryHandler(RealDatabase realDatabase) 
        {
            _realDatabase = realDatabase;
        }

        public Task<List<User>> Handle(GetAllUsersQuery request, CancellationToken cancellationToken)
        {
            List<User> allUsersFromRealDatabase = _realDatabase.Users.ToList();
            return Task.FromResult(allUsersFromRealDatabase);
        }
    }
}
