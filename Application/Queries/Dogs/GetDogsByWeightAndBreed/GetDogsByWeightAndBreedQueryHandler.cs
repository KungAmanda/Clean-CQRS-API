using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Dogs.GetDogByWeightAndBreed
{
    public class GetDogsByWeightAndBreedQueryHandler : IRequestHandler<GetDogsByWeightAndBreedQuery, List<Dog>>
    {
        private readonly RealDatabase _realDatabase;

        public GetDogsByWeightAndBreedQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<List<Dog>> Handle(GetDogsByWeightAndBreedQuery request, CancellationToken cancellationToken)
        {
            List<Dog> dogs = _realDatabase.Dogs
                .Where(dog =>
                    (!request.Weight.HasValue || dog.Weight == request.Weight) &&
                    (string.IsNullOrEmpty(request.Breed) || dog.Breed == request.Breed))
                .ToList();

            return Task.FromResult(dogs);
        }
    }
}
