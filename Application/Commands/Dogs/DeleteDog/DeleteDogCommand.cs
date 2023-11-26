using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediatR;


namespace Application.Commands.Dogs.DeleteDog
{
    public class DeleteDogCommand : IRequest<bool>
    {
        public Guid DogId { get; }

        public DeleteDogCommand(Guid dogId)
        {
            DogId = dogId;
        }
    }
}

