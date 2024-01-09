using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Cats.GetCatsByWeight_Breed
{
    public class GetCatsByWeightAndBreedQuery : IRequest<List<Cat>>
    {
        public int? Weight { get; set; }
        public string? Breed { get; set; }
    }


}
