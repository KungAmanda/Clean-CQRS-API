using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.UserAnimals.Queries.GetAllUserAnimals;

namespace API.Controllers.UserAnimalController
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserAnimalController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UserAnimalController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //get alla satana perkele djur och ägare
        [HttpGet]
        [Route("getAllUsersWithAnimals")]
        public async Task<IActionResult> GetAllUsersWithAnimals()
        {
            try
            {
                var userAnimal = await _mediator.Send(new GetAllUsersWithAnimalsQuery());

                return userAnimal == null ? NotFound("no animal and users found") : Ok(userAnimal);
            }
            catch (Exception ex)
            {

                return StatusCode(500, "Internal server error");
            }
        }
    }
}


