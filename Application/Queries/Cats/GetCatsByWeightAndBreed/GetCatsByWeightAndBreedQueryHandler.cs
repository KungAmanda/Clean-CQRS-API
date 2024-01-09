using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Cats.GetCatsByWeight_Breed
{
    public class GetCatsByWeightAndBreedQueryHandler : IRequestHandler<GetCatsByWeightAndBreedQuery, List<Cat>>
    {
        private readonly RealDatabase _realDatabase;

        public GetCatsByWeightAndBreedQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<List<Cat>> Handle(GetCatsByWeightAndBreedQuery request, CancellationToken cancellationToken)
        {
            List<Cat> cats = _realDatabase.Cats
                .Where(cat =>
                    (!request.Weight.HasValue || cat.Weight == request.Weight) &&
                    (string.IsNullOrEmpty(request.Breed) || cat.Breed == request.Breed))
                .ToList();

            return Task.FromResult(cats);
        }
    }

}
