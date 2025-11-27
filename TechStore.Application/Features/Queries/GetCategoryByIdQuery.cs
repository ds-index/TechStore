using MediatR;
using TechStore.Application.DTOs;

namespace TechStore.Application.Features.Queries
{
    public class GetCategoryByIdQuery: IRequest<ResCategoryDTO>
    {
        public int Id { get; set; }
    }
}
