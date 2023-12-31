﻿using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Birds.AddBird
{
    public class AddBirdCommandHandler : IRequestHandler<AddBirdCommand, Bird>
    {
        private readonly RealDatabase _realDatabase;

        public AddBirdCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }
        public Task<Bird> Handle(AddBirdCommand request, CancellationToken cancellationToken)
        {
            Bird birdToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewBird.Name,
                CanFly = request.NewBird.CanFly,
                Color = request.NewBird.Color
            };

            _realDatabase.Birds.Add(birdToCreate);
            _realDatabase.SaveChangesAsync(cancellationToken);

            return Task.FromResult(birdToCreate);
        }
    }
}
