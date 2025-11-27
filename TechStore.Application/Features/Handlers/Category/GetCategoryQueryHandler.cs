using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using TechStore.Application.DTOs;
using TechStore.Application.Features.Queries;
using TechStore.Application.Interfaces;
using TechStore.Domain.Entities;

namespace TechStore.Application.Features.Handlers.Category
{
    public class GetCategoryQueryHandler : IRequestHandler<GetCategoryQuery, List<ResCategoryDTO>>
    {
        private readonly IMapper _mapper;
        private readonly ILogger<GetCategoryQueryHandler> _logger;
        private readonly IRepository<CategoryDomain> _repository;

        public GetCategoryQueryHandler(IMapper mapper, 
            ILogger<GetCategoryQueryHandler> logger, 
            IRepository<CategoryDomain> repository)
        {
            _mapper = mapper;
            _logger = logger;
            _repository = repository;
        }

        public async Task<List<ResCategoryDTO>> Handle(GetCategoryQuery request, CancellationToken cancellationToken)
        {


            var categories = (await _repository.GetAllAsync()).
                OrderBy(x => x.Id);

            if (categories.Any())
            {
                _logger.LogInformation("Data successful get from db.");
                return _mapper.Map<List<ResCategoryDTO>>(categories);
            }
            else
            {
                _logger.LogError("Can't get data from db!");
                return null!;
            }

        }
    }
}
