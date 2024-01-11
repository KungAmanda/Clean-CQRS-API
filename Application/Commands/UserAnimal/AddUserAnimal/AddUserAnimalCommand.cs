using Application.Dtos;
using Domain.Models;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Commands.UserAnimal.AddUserAnimal
{
    public class AddUserAnimalCommand : IRequest<UserAnimalModel>
    {
        public AddUserAnimalCommand(UserAnimalDto newUserAnimal)
        {
            NewUserAnimal = newUserAnimal;
        }

        public UserAnimalDto NewUserAnimal { get; }
        public UserAnimalDto UserAnimal { get; set; }

    }
}
