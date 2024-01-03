using Domain.Models.Animal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class UserAnimalModel
    {
        [Key]
        public Guid Key { get; set; }
        public Guid AnimalId { get; set; }
        public AnimalModel Animal { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
    }
}
