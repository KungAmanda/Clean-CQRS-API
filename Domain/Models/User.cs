using Domain.Models;
using Domain.Models.Account;
using Domain.Models.Animal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Models
{
    public class User : AccountModel
    {
        public ICollection<UserAnimalModel> UserAnimal { get; set; }
    }
}
