
using MediatR;
using TechStore.Application.DTOs;

namespace TechStore.Application.Features.Queries
{
    public class GetProductByIdQuery : IRequest<ResProductDTO>
    {
        public int Id { get; set; }
    }
}
