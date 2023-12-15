using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries.Birds.GetAll
{
    public class GetAllBirdsQueryHandler : IRequestHandler<GetAllBirdsQuery, List<Bird>>
    {
        private readonly RealDatabase _realDatabase;

        public GetAllBirdsQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<List<Bird>> Handle(GetAllBirdsQuery request, CancellationToken cancellationToken)
        {
            List<Bird> allBirdsFromMockDatabase = _realDatabase.Birds.ToList();
            return Task.FromResult(allBirdsFromMockDatabase);
        }
    }
}