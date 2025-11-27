using AutoMapper;
using MediatR;
using Microsoft.Extensions.Logging;
using TechStore.Application.DTOs;
using TechStore.Application.Features.Queries;
using TechStore.Application.Interfaces;
using TechStore.Domain.Entities;

namespace TechStore.Application.Features.Handlers.Product
{
    public class GetProductQueryHandler : IRequestHandler<GetProductQuery, List<ResProductDTO>>
    {
        private readonly ILogger<GetProductQueryHandler> _logger;
        private readonly IMapper _mapper;
        private readonly IRepository<ProductDomain> _repository;

        public GetProductQueryHandler(ILogger<GetProductQueryHandler> logger, 
            IMapper mapper, 
            IRepository<ProductDomain> repository)
        {
            _logger = logger;
            _mapper = mapper;
            _repository = repository;
        }

        public async Task<List<ResProductDTO>> Handle(GetProductQuery request, CancellationToken cancellationToken)
        {
            try
            {
                var products = (await _repository.GetAllAsync())
                    .OrderBy(x => x.Id);

                if (products.Any())
                {
                    _logger.LogInformation("Data successful get from db.");
                    return _mapper.Map<List<ResProductDTO>>(products);
                }
                else
                {
                    throw new DirectoryNotFoundException($"Not found:\n {products}");
                }
            }
            catch(Exception ex)
            {
                _logger.LogError(ex.Message);
                return null!;
            }
        }
    }
}
