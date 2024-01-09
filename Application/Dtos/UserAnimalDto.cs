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
        //public User User { get; set; }
        //public AnimalModel Animal { get; set; }

        //public List<DogDto> Dogs { get; set; }
        //public List<CatDto> Cats { get; set; }
        //public List<BirdDto> Birds { get; set; }

    }
}