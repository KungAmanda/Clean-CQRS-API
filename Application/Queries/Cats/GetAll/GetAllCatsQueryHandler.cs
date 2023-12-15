using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Cats.GetAll
{
    public class GetAllCatsQueryHandler : IRequestHandler<GetAllCatsQuery, List<Cat>>
    {
        private readonly RealDatabase _realDatabase;

        public GetAllCatsQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }
        public Task<List<Cat>> Handle(GetAllCatsQuery request, CancellationToken cancellationToken)
        {
            List<Cat> allCatsFromMockDatabase = _realDatabase.Cats.ToList();
            _realDatabase.SaveChangesAsync(cancellationToken);
            return Task.FromResult(allCatsFromMockDatabase);
        }
    }

}
