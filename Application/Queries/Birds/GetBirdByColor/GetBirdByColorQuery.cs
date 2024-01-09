using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Birds.GetBirdByColor
{
    public class GetBirdByColorQuery : IRequest<List<Bird>>
    {
        public string? Color { get; set; }
    }
}
