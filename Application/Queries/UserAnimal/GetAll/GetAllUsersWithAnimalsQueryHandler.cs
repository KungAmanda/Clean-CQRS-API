using Application.Dtos;
using Domain.Models;
using FluentValidation.Results;
using Infrastructure.Database;
using MediatR;
using Microsoft.EntityFrameworkCore;

namespace Application.UserAnimals.Queries.GetAllUserAnimals
{
    public class GetAllAnimalUsersQueryHandler : IRequestHandler<GetAllUsersWithAnimalsQuery, List<UserAnimalDto>>
    {
        private readonly RealDatabase _realDatabase;

        public GetAllAnimalUsersQueryHandler(RealDatabase realDatabase)
        {
            _realDatabase = realDatabase;
        }




        // den hämtar bara id nu jag vill ändra så med hjälp av userid hämta namnen också
        public async Task<List<UserAnimalDto>> Handle(GetAllUsersWithAnimalsQuery request, CancellationToken cancellationToken)
        {
            var userAnimal = await _realDatabase.UserAnimals.ToListAsync();


            //avvaktar med detta och går vidare med annat för att få klart uppgiften s jag kan fokusera på grupparbete men det funkar iaf att hämta id på relationerna 
            ////gör en ny variabel som ska hämta namnen till djuren och users

            //var users = await _realDatabase.Users.ToListAsync();
            //var animals = await _realDatabase.Animals.ToListAsync();

            //foreach  ( var user in  users)
            //{



            //    // för varje användare med hjälp av userid hämta alla animalid som kopplade med den user
            //}




            return userAnimal.Select(au => new UserAnimalDto
            {
                AnimalId = au.AnimalId,
                UserId = au.UserId
            }).ToList();


        }
    }
}
