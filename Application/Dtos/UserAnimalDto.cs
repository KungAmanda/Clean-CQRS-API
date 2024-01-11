using Domain.Models;
using Domain.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Dtos
{
    public class UserAnimalDto
    {

        public Guid AnimalId { get; set; }

        public Guid UserId { get; set; }


    }
}