using MediatR;
using TechStore.Application.DTOs;

namespace TechStore.Application.Features.Queries
{
    public class GetProductQuery: IRequest<List<ResProductDTO>>
    {

    }
}
