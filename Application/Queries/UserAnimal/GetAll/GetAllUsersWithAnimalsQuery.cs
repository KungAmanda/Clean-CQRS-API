using Application.Dtos;
using Domain.Models;
using MediatR;

namespace Application.UserAnimals.Queries.GetAllUserAnimals
{
    public class GetAllUsersWithAnimalsQuery : IRequest<List<UserAnimalDto>>
    {
    }
}
