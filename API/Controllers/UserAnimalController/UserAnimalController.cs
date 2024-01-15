using Microsoft.AspNetCore.Mvc;
using MediatR;
using Application.UserAnimals.Queries.GetAllUserAnimals;
using Application.Dtos;
using Application.Commands.UserAnimal.AddUserAnimal;
using Application.Commands.UserAnimal.DeleteUserAnimal;
using Application.Commands.UserAnimal.UpdateUserAnimal;
using Application.Validators.UserAnimal;
using System;
using System.Threading.Tasks;

namespace API.Controllers.UserAnimalController
{
    [Route("api/[controller]")]
    [ApiController]

    public class UserAnimalController : ControllerBase
    {
        private readonly IMediator _mediator;
        private readonly UserAnimalValidator _userAnimalValidator;

        public UserAnimalController(IMediator mediator, UserAnimalValidator userAnimalValidator)
        {
            _mediator = mediator;
            _userAnimalValidator = userAnimalValidator;
        }

        //get all satana perkele djur och ägare
        [HttpGet]
        [Route("getAllUsersWithAnimals")]
        public async Task<IActionResult> GetAllUsersWithAnimals()
        {
            try
            {
                var userAnimal = await _mediator.Send(new GetAllUsersWithAnimalsQuery());

                return userAnimal == null ? NotFound("no animal and users found") : Ok(userAnimal);
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        //Create a new useranimal relation
        [HttpPost]
        [Route("CreateUserAnimalRelation")]
        public async Task<IActionResult> AddUserAnimal([FromBody] UserAnimalDto newUserAnimal)
        {
            try
            {
                var validationResult = await _userAnimalValidator.ValidateAsync(newUserAnimal);

                if (!validationResult.IsValid)
                {
                    return BadRequest(validationResult.Errors);
                }

                return Ok(await _mediator.Send(new AddUserAnimalCommand(newUserAnimal)));
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // delete relation 
        [HttpDelete]
        [Route("deleteUserAnimalRelation")]
        public async Task<IActionResult> DeleteUserAnimal(Guid Key)
        {
            try
            {
                var command = new DeleteUserAnimalByIdCommand(Key);
                var result = await _mediator.Send(command);

                if (result != null)
                {
                    return NoContent();
                }

                return NotFound("Relation not found in the list");
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut]
        [Route("updateUserAnimal/{key}")]
        public async Task<IActionResult> UpdateUserAnimal([FromBody] UserAnimalDto updateUserAnimal, Guid key)
        {
            try
            {
                var validationResult = await _userAnimalValidator.ValidateAsync(updateUserAnimal);

                if (!validationResult.IsValid)
                {
                    return BadRequest(validationResult.Errors);
                }

                return Ok(await _mediator.Send(new UpdateUserAnimalByIdCommand(updateUserAnimal, key)));
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }
    }
}
