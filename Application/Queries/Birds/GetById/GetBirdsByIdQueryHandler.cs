using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Queries.Birds.GetById
{
    public class GetBirdByIdQueryHandler : IRequestHandler<GetBirdByIdQuery, Bird>
    {
        private readonly RealDatabase _realDatabase;

        public GetBirdByIdQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<Bird> Handle(GetBirdByIdQuery request, CancellationToken cancellationToken)
        {
            Bird wantedBird = _realDatabase.Birds.FirstOrDefault(bird => bird.Id == request.Id)!;

            _realDatabase.SaveChangesAsync(cancellationToken);

            return Task.FromResult(wantedBird);
        }
    }
}