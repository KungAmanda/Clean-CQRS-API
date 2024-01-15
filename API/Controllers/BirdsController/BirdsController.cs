using Application.Commands.Birds;
using Application.Commands.Birds.AddBird;
using Application.Commands.Birds.DeleteBird;
using Application.Commands.Birds.UpdateBird;
using Application.Dtos;
using Application.Queries.Birds.GetAll;
using Application.Queries.Birds.GetBirdByColor;
using Application.Queries.Birds.GetById;
using Application.Validators.Bird;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace API.Controllers.BirdsController
{
    [Route("api/[controller]")]
    [ApiController]
    public class BirdsController : ControllerBase
    {
        internal readonly IMediator _mediator;
        private readonly BirdValidator _birdValidator;

        public BirdsController(IMediator mediator, BirdValidator birdValidator)
        {
            _mediator = mediator;
            _birdValidator = birdValidator;
        }

        //Get all Birds from Db
        [HttpGet]
        [Route("getAllBirds")]
        public async Task<IActionResult> GetAllBirds()
        {
            return Ok(await _mediator.Send(new GetAllBirdsQuery()));
        }

        //Get Bird By Id
        [HttpGet]
        [Route("getBirdById/{birdId}")]
        public async Task<IActionResult> GetBirdById(Guid birdId)
        {
            return Ok(await _mediator.Send(new GetBirdByIdQuery(birdId)));
        }

        // Get birds by Color
        [HttpGet]
        [Route("getBirdsByColor")]
        public async Task<IActionResult> GetBirdsByColor(string color)
        {
            return Ok(await _mediator.Send(new GetBirdByColorQuery
            {
                Color = color
            }));
        }

        //Create a new Bird
        [HttpPost]
        [Route("addNewBird")]
        public async Task<IActionResult> AddBird([FromBody] BirdDto newBird)
        {
            var validationResult = await _birdValidator.ValidateAsync(newBird);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            return Ok(await _mediator.Send(new AddBirdCommand(newBird)));
        }

        //Update a specific Bird
        [HttpPut]
        [Route("updateBird/{updateBirdId}")]
        public async Task<IActionResult> UpdateBird([FromBody] BirdDto updatedBird, Guid updateBirdId)
        {
            var validationResult = await _birdValidator.ValidateAsync(updatedBird);

            if (!validationResult.IsValid)
            {
                return BadRequest(validationResult.Errors);
            }

            return Ok(await _mediator.Send(new UpdateBirdByIdCommand(updatedBird, updateBirdId)));
        }

        [HttpDelete]
        [Route("deletebird/{Id}")]
        public async Task<IActionResult> DeleteBird(Guid Id)
        {
            var command = new DeleteBirdByIdCommand(Id);
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return NoContent();
            }

            return NotFound("Bird not found in the list");
        }
    }
}
