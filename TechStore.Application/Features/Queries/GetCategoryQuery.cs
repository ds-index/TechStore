using MediatR;
using TechStore.Application.DTOs;

namespace TechStore.Application.Features.Queries
{
    public class GetCategoryQuery : IRequest<List<ResCategoryDTO>>
    {
    }
}
