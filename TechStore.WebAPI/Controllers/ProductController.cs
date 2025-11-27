using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TechStore.Application.Features.Commands.Product;
using TechStore.Application.Features.Queries;

namespace TechStore.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProductController(IMediator mediator) => _mediator = mediator;


        [HttpGet]
        [Route("GetAllProduct")]
        public async Task<IActionResult> GetAllProduct()
        {
            var products = await _mediator.Send(new GetProductQuery());

            if(products.Any())
            {
                return Ok(products);
            }
            return NotFound("Not found products!");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetProductById([FromRoute] int id)
        {
            if(id == 0)
            {
                return BadRequest($"Bad Request with id: {id}.");
            }

            var product = await _mediator.Send(new GetProductByIdQuery() { Id = id });

            if(product is null)
            {
                return NotFound($"Not found product with id: {id}.");
            }

            return Ok(product);
        }

        [Authorize(Roles = "Admin")]
        [HttpPost]
        public async Task<IActionResult> CreateProduct([FromBody]CreateProductCommand command)
        {
            if(command is null)
            {
                return BadRequest("Empty product command!");
            }

            var result = await _mediator.Send(new CreateProductCommand()
            {
                ProductName = command.ProductName,
                ProductDescription = command.ProductDescription,
                Price = command.Price,
                Inventory = command.Inventory,
                CategoryId = command.CategoryId,
            });

            if(result != 0)
            {
                return CreatedAtAction(nameof(GetProductById), new {Id =  result}, command);
            }

            return BadRequest("Can't create new product!");
        }

        [Authorize(Roles = "Admin")]
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateProduct([FromRoute] int id, [FromBody]UpdateProductCommand command)
        {

            if(id == 0 || command is null)
            {
                return BadRequest("Id is 0 or command data is null!");
            }

            var result = await _mediator.Send(new UpdateProductCommand()
            {
                Id = id,
                ProductName = command.ProductName,
                ProductDescription = command.ProductDescription,
                Price = command.Price,
                Inventory = command.Inventory,
                CategoryId = command.CategoryId,
            });

            if(result)
            {
                return NoContent();
            }
            return BadRequest("Can't update product!");
        }

        [Authorize(Roles = "Admin")]
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProduct([FromRoute]int id)
        {
            if(id == 0)
            {
                return BadRequest("Bad request with id 0.");
            }

            var result = await _mediator.Send(new DeleteProductCommand() { Id = id });

            if(result)
            {
                return NoContent();
            }

            return BadRequest("Can't delete product!");
        }
    }
}
