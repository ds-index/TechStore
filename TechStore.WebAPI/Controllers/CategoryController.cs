using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechStore.Application.Features.Commands.Category;
using TechStore.Application.Features.Queries;
using TechStore.WebAPI.Filters;

namespace TechStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CategoryController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        [Route("GetAllCategory")]
        public async Task<IActionResult> GetAllCategories()
        {
            var result = await _mediator.Send(new GetCategoryQuery());

            if (result is null)
            {
                return NotFound("Not found category!");
            }
            return Ok(result);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetCategoryWithId([FromRoute] int id)
        {
            var category = await _mediator.Send(new GetCategoryByIdQuery { Id = id });

            if (category is null)
            {
                return NotFound("Not found category!");
            }
            return Ok(category);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        [ValidateModelAttribute]
        public async Task<IActionResult> CreateCategory([FromBody] CreateCategoryCommand command)
        {
            try
            {
                var categoryId = await _mediator.Send(new CreateCategoryCommand
                {
                    CategoryName = command.CategoryName,
                    CategoryDescription = command.CategoryDescription,
                });

                return CreatedAtAction(nameof(GetCategoryWithId), new { id = categoryId }, new { Id = categoryId });
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        [ValidateModelAttribute]
        public async Task<IActionResult> UpdateCategory([FromRoute] int id, [FromBody] UpdateCategoryCommand command)
        {
            if (id == 0)
            {
                return BadRequest("Not found category with 0 Id!");
            }

            var result = await _mediator.Send(new UpdateCategoryCommand()
            {
                Id = id,
                CategoryName = command.CategoryName,
                CategoryDescription = command.CategoryDescription,
            });

            if (!result)
            {
                return NotFound("Not found!");
            }
            return NoContent();
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        [ValidateModelAttribute]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            if(id == 0)
            {
                return BadRequest("Not found category with 0 Id!");
            }

            var result = await _mediator.Send(new DeleteCategoryCommand() { Id = id });

            if(!result)
            {
                return NotFound("Not found category!");
            }

            return NoContent();
        }
    }
}
