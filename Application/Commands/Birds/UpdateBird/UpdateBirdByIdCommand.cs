using Application.Dtos;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.Birds.UpdateBird
{
    public class UpdateBirdByIdCommand : IRequest<Bird>
    {
        public UpdateBirdByIdCommand(BirdDto updatedBird, Guid id, bool canFly)
        {
            UpdatedBird = updatedBird;
            Id = id;
            CanFly = canFly;
        }

        public BirdDto UpdatedBird { get; }
        public Guid Id { get; }
        public bool CanFly { get; }
    }
}
