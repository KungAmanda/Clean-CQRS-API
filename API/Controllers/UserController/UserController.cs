using Application.Commands.Users.DeleteUser;
using Application.Commands.Users.UpdateUser;
using Application.Dtos;
using Application.Queries.Users.GetAll;
using Application.Queries.Users.GetById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace API.Controllers.UsersController
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class UsersController : ControllerBase
    {
        private readonly IMediator _mediator;

        public UsersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        // Get all users from database
        [HttpGet]
        [Route("getAllUsers")]
        public async Task<IActionResult> GetAllUsers()
        {
            return Ok(await _mediator.Send(new GetAllUsersQuery()));
        }

        // Get a user by Id
        [HttpGet]
        [Route("getUserById/{userId}")]
        public async Task<IActionResult> GetUserById(Guid userId)
        {
            return Ok(await _mediator.Send(new GetUserByIdQuery(userId)));
        }

      

        // Update a specific user
        [HttpPut]
        [Route("updateUser/{updatedUserId}")]
        public async Task<IActionResult> UpdateUser([FromBody] UserDto updatedUser, Guid updatedUserId)
        {
            return Ok(await _mediator.Send(new UpdateUserByIdCommand(updatedUser, updatedUserId)));
        }

        [HttpDelete]
        [Route("deleteUser/{Id}")]
        public async Task<IActionResult> DeleteUser(Guid Id)
        {
            var command = new DeleteUserByIdCommand(Id);
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return NoContent();
            }

            return NotFound("User not found in the list.");
        }
    }
}
