﻿using Domain.Models;
using Infrastructure.Database;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Queries.Cats.GetById
{
    public class GetCatByIdQueryHandler : IRequestHandler<GetCatByIdQuery, Cat>
    {
        private readonly RealDatabase _realDatabase;
        public GetCatByIdQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }
        public Task<Cat> Handle(GetCatByIdQuery request, CancellationToken cancellationToken)
        {
            Cat wantedCat = _realDatabase.Cats.FirstOrDefault(cat => cat.Id == request.Id)!;
            return Task.FromResult(wantedCat);
        }
    }
}