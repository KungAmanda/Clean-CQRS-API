﻿using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Commands.Cats.UpdateCat
{

    public class UpdateCatByIdCommandHandler : IRequestHandler<UpdateCatByIdCommand, Cat>
    {
        private readonly RealDatabase _realDatabase;

        public UpdateCatByIdCommandHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }
        public Task<Cat> Handle(UpdateCatByIdCommand request, CancellationToken cancellationToken)
        {
            Cat catToUpdate = _realDatabase.Cats.FirstOrDefault(cat => cat.Id == request.Id)!;

            catToUpdate.Name = request.UpdatedCat.Name;
            catToUpdate.LikesToPlay = request.UpdatedCat.LikesToPlay;
            catToUpdate.Breed = request.UpdatedCat.Breed;
            catToUpdate.Weight = request.UpdatedCat.Weight;


            _realDatabase.SaveChangesAsync(cancellationToken);


            return Task.FromResult(catToUpdate);
        }
    }

}
