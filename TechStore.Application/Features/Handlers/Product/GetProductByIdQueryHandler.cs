using AutoMapper;
using MediatR;
using TechStore.Application.DTOs;
using TechStore.Application.Features.Queries;
using TechStore.Application.Interfaces;
using TechStore.Domain.Entities;

namespace TechStore.Application.Features.Handlers.Product
{
    public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ResProductDTO>
    {
        private readonly IMapper _mapper;
        private readonly IRepository<ProductDomain> _repo;

        public GetProductByIdQueryHandler(IMapper mapper, Interfaces.IRepository<ProductDomain> repo)
        {
            _mapper = mapper;
            _repo = repo;
        }

        public async Task<ResProductDTO> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var product = await _repo.GetByIdAsync(request.Id);

            if(product is null)
            {
                return null!;
            }
            var result = _mapper.Map<ResProductDTO>(product);

            return result;
        }
    }
}
