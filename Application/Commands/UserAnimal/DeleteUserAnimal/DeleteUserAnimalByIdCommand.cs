using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.UserAnimal.DeleteUserAnimal
{
    public class DeleteUserAnimalByIdCommand : IRequest<UserAnimalModel>
    {
        public DeleteUserAnimalByIdCommand(Guid key)
        {
            Key = key;
        }

        public Guid Key { get; set; }
    }
}
