using Application.Queries.Dogs.GetAll;
using Application.Queries.Dogs.GetById;
using Domain.Models;
using Infrastructure.Database;
using MediatR;

namespace Application.Queries.Dogs
{
    public class GetAllDogsQueryHandler : IRequestHandler<GetAllDogsQuery, List<Dog>>
    {
        private readonly MockDatabase _mockDatabase;

        public GetAllDogsQueryHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }
        public Task<List<Dog>> Handle(GetAllDogsQuery request, CancellationToken cancellationToken)
        {
            List<Dog> allDogsFromMockDatabase = _mockDatabase.Dogs;
            return Task.FromResult(allDogsFromMockDatabase);
        }

        //public static implicit operator GetAllDogsQueryHandler(GetDogByIdQueryHandler v)
        //{
        //    throw new NotImplementedException();
        //}
    }
}
