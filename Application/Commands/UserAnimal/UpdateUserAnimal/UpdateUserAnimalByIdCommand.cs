using Application.Dtos;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.UserAnimal.UpdateUserAnimal
{
    public class UpdateUserAnimalByIdCommand : IRequest<UserAnimalModel>
    {
        public UpdateUserAnimalByIdCommand(UserAnimalDto updateUserAnimal, Guid key)
        {
            UpdateUserAnimal = updateUserAnimal;
            Key = key;
        }

        public UserAnimalDto UpdateUserAnimal { get; }
        public Guid Key { get; }

    }
}
