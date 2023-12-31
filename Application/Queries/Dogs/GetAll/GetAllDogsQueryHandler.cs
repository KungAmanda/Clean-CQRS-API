﻿using Application.Queries.Dogs.GetAll;
using Application.Queries.Dogs.GetById;
using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Dogs
{
    public class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuery, List<Dog>>
    {
        private readonly RealDatabase _realDatabase;

        public GetAllDogsQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }
        public Task<List<Dog>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            List<Dog> allDogsFromMockDatabase = _realDatabase.Dogs.ToList();
            _realDatabase.SaveChangesAsync(cancellationToken);
            return Task.FromResult(allDogsFromMockDatabase);
        }


    }
}