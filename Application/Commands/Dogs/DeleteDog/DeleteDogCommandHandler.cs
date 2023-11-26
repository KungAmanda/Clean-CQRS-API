using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.Database;
using MediatR;

namespace Application.Commands.Dogs.DeleteDog
{
    public class DeleteDogCommandHandler : IRequestHandler<DeleteDogCommand, bool>
    {
        private readonly MockDatabase _mockDatabase;

        public DeleteDogCommandHandler(MockDatabase mockDatabase)
        {
            _mockDatabase = mockDatabase;
        }

        public Task<bool> Handle(DeleteDogCommand request, CancellationToken cancellationToken)
        {
            // Här kan du implementera logik för att ta bort hunden från databasen
            // Returnera true om borttagningen är framgångsrik, annars false
            var success = _mockDatabase.DeleteDog(request.DogId);
            return Task.FromResult(success);
        }
    }
}
