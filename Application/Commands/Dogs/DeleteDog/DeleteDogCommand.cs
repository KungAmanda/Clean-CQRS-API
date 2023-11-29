using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Models;
using MediatR;


namespace Application.Commands.Dogs.DeleteDog
{
    public class DeleteDogCommand : IRequest<Dog>
    {
        public DeleteDogCommand(Guid id)
        {
            Id = id;
        }
        public Guid Id { get; set; }
    }
}

