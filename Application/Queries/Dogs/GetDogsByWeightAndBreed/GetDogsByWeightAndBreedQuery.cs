using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Dogs.GetDogByWeightAndBreed
{
    public class GetDogsByWeightAndBreedQuery : IRequest<List<Dog>>
    {
        public int? Weight { get; set; }
        public string? Breed { get; set; }


    }
}
