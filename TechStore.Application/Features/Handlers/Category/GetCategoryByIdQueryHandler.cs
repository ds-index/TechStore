using AutoMapper;
using MediatR;
using TechStore.Application.DTOs;
using TechStore.Application.Features.Queries;
using TechStore.Application.Interfaces;
using TechStore.Domain.Entities;

namespace TechStore.Application.Features.Handlers.Category
{
    public class GetCategoryByIdQueryHandler : IRequestHandler<GetCategoryByIdQuery, ResCategoryDTO>
    {
        private readonly IRepository<CategoryDomain> _repo;
        private readonly IMapper _mapper;

        public GetCategoryByIdQueryHandler(IRepository<CategoryDomain> repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        public async Task<ResCategoryDTO> Handle(GetCategoryByIdQuery request, CancellationToken cancellationToken)
        {
            var category = await _repo.GetByIdAsync(request.Id);

            if(category == null)
            {
                return null!;
            }
            else
            {
                var result = _mapper.Map<ResCategoryDTO>(category);

                return result;
            }
        }
    }
}
