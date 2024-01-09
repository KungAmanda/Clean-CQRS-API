using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Birds.GetBirdByColor
{
    public class GetBirdByColorQueryHandler : IRequestHandler<GetBirdByColorQuery, List<Bird>>
    {
        private readonly RealDatabase _realDatabase;

        public GetBirdByColorQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<List<Bird>> Handle(GetBirdByColorQuery request, CancellationToken cancellationToken)
        {
            List<Bird> birds = _realDatabase.Birds
                .Where(bird => string.IsNullOrEmpty(request.Color) || bird.Color == request.Color)
                .ToList();

            return Task.FromResult(birds);
        }
    }
}
