using Application.Commands.Cats;
using Application.Commands.Cats.AddCat;
using Application.Commands.Cats.DeleteCat;
using Application.Commands.Cats.UpdateCat;
using Application.Dtos;
using Application.Queries.Cats.GetAll;
using Application.Queries.Cats.GetById;
using Application.Queries.Cats.GetAll;
using Application.Queries.Cats.GetById;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;
using Application.Queries.Cats.GetCatsByWeight_Breed;
using Domain.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API.Controllers.CatsController
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class CatsController : ControllerBase
    {
        internal readonly IMediator _mediator;
        public CatsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        //Get all Cats from Db
        [HttpGet]
        [Route("getAllCats")]
        public async Task<IActionResult> GetAllCats()
        {
            try
            {
                return Ok(await _mediator.Send(new GetAllCatsQuery()));
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        //Get Cat By Id
        [HttpGet]
        [Route("getCatById/{catId}")]
        public async Task<IActionResult> GetCatById(Guid catId)
        {
            try
            {
                return Ok(await _mediator.Send(new GetCatByIdQuery(catId)));
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        // Get cats by Weight and Breed
        [HttpGet]
        [Route("getCatsByWeightAndBreed")]
        public async Task<IActionResult> GetCatsByWeightAndBreed(int? weight, string breed)
        {
            try
            {
                return Ok(await _mediator.Send(new GetCatsByWeightAndBreedQuery
                {
                    Weight = weight,
                    Breed = breed
                }));
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }


        }


        //Create a new Cat
        [HttpPost]
        [Route("addNewCat")]
        public async Task<IActionResult> AddCat([FromBody] CatDto newCat)
        {
            try
            {
                return Ok(await _mediator.Send(new AddCatCommand(newCat)));
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpPut]
        [Route("updateCat/{updatedCatId}")]
        public async Task<IActionResult> UpdateCat([FromBody] CatDto updatedCat, Guid updatedCatId)
        {
            try
            {
                return Ok(await _mediator.Send(new UpdateCatByIdCommand(updatedCat, updatedCatId)));
            }
            catch (Exception)
            {
                return StatusCode(500, "Internal server error");
            }

        }


        [HttpDelete]
        [Route("deletecat/{Id}")]
        public async Task<IActionResult> DeleteCat(Guid Id)
        {
            var command = new DeleteCatByIdCommand(Id);
            var result = await _mediator.Send(command);

            if (result != null)
            {
                return NoContent();
            }

            return NotFound("Cat not found in the list");
        }

    }

}

