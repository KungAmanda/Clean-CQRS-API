﻿using Application.Commands.Birds;
using Application.Commands.Birds.AddBird;
using Application.Commands.Birds.DeleteBird;
using Application.Commands.Birds.UpdateBird;
using Application.Dtos;
using Application.Queries.Birds.GetAll;
using Application.Queries.Birds.GetById;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Threading.Tasks;

namespace API.Controllers.BirdsController
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class BirdsController : ControllerBase
    {
        internal readonly IMediator _mediator;

        public BirdsController(IMediator mediator)
        {
            _mediator = mediator;
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

        //Create a new Bird
        [HttpPost]
        [Route("addNewBird")]
        public async Task<IActionResult> AddBird([FromBody] BirdDto newBird)
        {
            return Ok(await _mediator.Send(new AddBirdCommand(newBird)));
        }

        //Update a specific Bird
        [HttpPut]
        [Route("updateBird/{updateBirdId}")]
        public async Task<IActionResult> UpdateBird([FromBody] BirdDto updatedBird, Guid updateBirdId)
        {
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
