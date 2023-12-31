﻿using Application.Commands.Cats;
using Domain.Models;
using Infrastructure.Database;
using MediatR;


namespace Application.Commands.Cats.AddCat
{
    public class AddCatCommandHandler : IRequestHandler<AddCatCommand, Cat>
    {
        private readonly RealDatabase _realDatabase;

        public AddCatCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }

        public Task<Cat> Handle(AddCatCommand request, CancellationToken cancellationToken)
        {
            Cat catToCreate = new()
            {
                Id = Guid.NewGuid(),
                Name = request.NewCat.Name,
                LikesToPlay = request.NewCat.LikesToPlay,
                Breed = request.NewCat.Breed,
                Weight = request.NewCat.Weight
            };



            _realDatabase.Cats.Add(catToCreate);
            _realDatabase.SaveChangesAsync(cancellationToken);


            return Task.FromResult(catToCreate);
        }
    }
}
